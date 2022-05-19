/*  Created by: 
 *  Project: Brick Breaker
 *  Date: 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml;

namespace BrickBreaker
{
    public partial class GameScreen : UserControl
    {
        #region global value
        int powerUpTimer;

        Random r = new Random();
        //player1 button control keys - DO NOT CHANGE
        Boolean leftArrowDown, rightArrowDown, spaceBarDown;

        // Game values
        int lives;

        // Paddle and Ball objects
        Paddle paddle;
        Ball ball;
        PowerUp powerUp;

        //list of powerups for current level
        List<PowerUp> powerups = new List<PowerUp>();
        int powerUpCheck;
        // list of all blocks for current level
        List<Block> blocks = new List<Block>();

        // Brushes
        SolidBrush paddleBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.White);
        SolidBrush powerupBrush = new SolidBrush(Color.Green);


        #endregion

        //game values
        int currentLevel;

        public GameScreen()
        {
            InitializeComponent();
            OnStart();
        }

        public void OnStart()
        {
            //set life counter
            lives = 3;

            //set all button presses to false.
            leftArrowDown = rightArrowDown = false;

            //charlie player
            int paddleWidth = 80;
            int paddleHeight = 20;
            int paddleX = ((this.Width / 2) - (paddleWidth / 2));
            int paddleY = (this.Height - paddleHeight) - 60;
            int paddleSpeed = 8;
            paddle = new Paddle(paddleX, paddleY, paddleWidth, paddleHeight, paddleSpeed, Color.Khaki);

            // setup starting ball values
            int ballX = this.Width / 2 - 10;
            int ballY = this.Height - paddle.height - 80;

            // Creates a new ball
            Random Randgen = new Random();
            int xSpeed = 6;
            int ySpeed = 6;
            int ballSize = 20;
            ball = new Ball(ballX, ballY, xSpeed, ySpeed, ballSize);

           currentLevel = 1;

           nextLevel();
       
            // start the game engine loop
            gameTimer.Enabled = true;

            //setup powerup values for testing purposes
            int powerUpX =0;
            int powerUpY =0;
            int powerUpSpeed = 3;
            int powerUpSize = ballSize / 2;
            powerUp = new PowerUp(powerUpX, powerUpY, powerUpSpeed, powerUpSize);



        }
        #region Creates blocks for generic level. Need to replace with code that loads levels.

        //TODO - replace all the code in this region eventually with code that loads levels from xml files
        //reads Xml file then creates objects from the infomation in the xml file 
        public void xmlLoad()
        {
            //counter to use when level is cleared of blocks/bricks 
            int blockCounter;
            //intergers for level objects 
            int newX, newY, newHp;
            //strings for levels objects and locations 
            string x, y, hp;
            //colour for colour objects 
            Color newColour;

            XmlReader reader = XmlReader.Create("Resources/level1.xml");
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    x = reader.ReadContentAsString();

                    newX = Convert.ToInt32(x);

                    reader.ReadToNextSibling("y");
                    newY = Convert.ToInt32(reader.ReadString());


                    reader.ReadToNextSibling("hp");
                    newHp = Convert.ToInt32(reader.ReadString());


                    reader.ReadToNextSibling("colour");
                    newColour = Color.FromName(reader.ReadString());

                    Block blocklevel = new Block(newX, newY, newHp, newColour);
                    blocks.Add(blocklevel);
                }
            }
            reader.Close();
       

        }


        #endregion


        //code to go from one level to the next
        public void nextLevel()
        {
            blocks.Clear();
            string level = $"level0{currentLevel}.xml";

            try
            {
                XmlReader reader = XmlReader.Create(level);

                int newX, newY, newHp;
                Color newColour;

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        newX = Convert.ToInt32(reader.ReadString());

                        reader.ReadToNextSibling("y");
                        newY = Convert.ToInt32(reader.ReadString());

                        reader.ReadToNextSibling("hp");
                        newHp = Convert.ToInt32(reader.ReadString());

                        reader.ReadToNextSibling("colour");
                        newColour = Color.FromName(reader.ReadString());

                        Block b = new Block(newX, newY, newHp, newColour);
                        blocks.Add(b);
                    }
                }
                reader.Close();
            }
            catch
            {
                //if level doesnt exist then switch loser screen
                OnEnd();
                return;
            }

        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                default:
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            //player 1 button releases
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                default:
                    break;
            }
        }



        private void gameTimer_Tick(object sender, EventArgs e)
        {
            {
                lifeCount.Text = $"{lives}";
                powerUpTimer--;
                if (powerUpTimer >= 0)
                {
                    powerUpTimerLabel.Visible = true;
                    powerUpTimerLabel.Text = $"{powerUpTimer}";
                }
                // Move the paddle
                if (leftArrowDown && paddle.x > 0)
                {
                    paddle.Move("left");
                }
                if (rightArrowDown && paddle.x < (this.Width - paddle.width))
                {
                    paddle.Move("right");
                }

                // Move ball
                ball.Move();

                //Drop powerups down
                foreach (PowerUp powerUp in powerups)
                {
                    powerUp.Move();
                }

                // Check for collision with top and side walls
                ball.WallCollision(this);

                // Check for ball hitting bottom of screen
                if (ball.BottomCollision(this))
                {
                    lives--;

                    // Moves the ball back to origin
                    ball.x = ((paddle.x - (ball.size / 2)) + (paddle.width / 2));
                    ball.y = (this.Height - paddle.height) - 85;

                if (lives == 0)
                {
                    OnEnd();
                }

                // Check for collision of ball with paddle, (incl. paddle movement)
                ball.PaddleCollision(paddle);

                //Check for collision of powerup and paddle
                try
                {
                    foreach (PowerUp p in powerups)
                    {
                        if (p.PaddleCollide(paddle))
                        {
                            powerups.Remove(p);
                            //start poweruptimer 
                            powerUpTimer = 800;
                            //increase length of  (comment back in after testing others)
                            if (p.powerUpType == "Long Paddle")
                            {
                                if (paddle.width < 250)
                                {
                                    paddle.width = paddle.width + 50;
                                }
                                else
                                {
                                    lives++;
                                }
                            }
                            //add life
                            else if (p.powerUpType == "Add Life")
                            { lives++; }
                            //speed up paddle and shorten it
                            else if (p.powerUpType == "Short Paddle")
                            {
                                if (paddle.speed < 12 && paddle.width > 20)
                                {
                                    paddle.speed = paddle.speed + 4;
                                    paddle.width = paddle.width - 20;
                                }
                                else
                                {
                                    lives++;
                                }

                            }
                            else if (p.powerUpType == "Large Ball")
                            { //increase ball size
                                if (ball.size < 50)
                                {
                                    ball.size = ball.size + ball.size / 2;
                                }
                                else
                                {
                                    lives++;
                                }
                            }
                        }

                    }
                }
                catch
                {
                }

                // Check if ball has collided with any blocks
                foreach (Block b in blocks)
                {
                    if (ball.BlockCollision(b))
                    {

                        blocks.Remove(b);

                        //check if powerups spawn
                        powerUpCheck = r.Next(0, 2);
                        if (powerUpCheck == 1)
                        {
                            int powerUpX = b.x;
                            int powerUpY = b.y;
                            int powerUpSpeed = 3;
                            int powerUpSize = 10;



                            powerUp = new PowerUp(powerUpX, powerUpY, powerUpSpeed, powerUpSize);
                            powerups.Add(powerUp);
                            powerUp.PowerUpChoice();
                        }
                        if (blocks.Count == 0)
                        {
                            currentLevel++;
                            nextLevel();
                        }

                        break;
                    }
                }

                if (powerUpTimer == 0)
                {
                    Reset_PowerUps();
                }

                //redraw the screen
                Refresh();
            }
        }

        public void OnEnd()
        {
            //stop game timer
            gameTimer.Enabled = false;

            // Goes to the game over screen
            Form form = this.FindForm();
            GameoverScreen gos = new GameoverScreen();
            
            gos.Location = new Point((form.Width - gos.Width) / 2, (form.Height - gos.Height) / 2);

            form.Controls.Add(gos);
            form.Controls.Remove(this);
        }
        public void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            // Draws paddle
            paddleBrush.Color = paddle.colour;
            e.Graphics.FillRectangle(paddleBrush, paddle.x, paddle.y, paddle.width, paddle.height);

            // Draws blocks
            foreach (Block b in blocks)
            {
                e.Graphics.FillRectangle(new SolidBrush(b.colour), b.x, b.y, b.width, b.height);
            }

            // Draws ball
            e.Graphics.FillEllipse(ballBrush, ball.x, ball.y, ball.size, ball.size);

            //Draws PowerUp

            foreach (PowerUp powerUp in powerups )
            {
                e.Graphics.FillRectangle(powerupBrush, powerUp.x, powerUp.y, powerUp.size, powerUp.size);
            }
        }
        public void Reset_PowerUps()
        {
            powerUpTimerLabel.Visible = false;
            paddle.width = 80;
            paddle.height = 20;
            paddle.speed = 8;
            ball.size = 20;
        }

    }
}
