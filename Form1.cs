namespace boxing
{
    public partial class Form1 : Form
    {

        bool playerblock = false;
        bool enemyblock = false;
        Random random = new Random();
        int enemySpeed = -50;
        int index = 0;
        int playerHealth =  10 ;
        int enemyHealth = 10000;
        List<string> enemyAttack = new List<string> { "left", "right ", "Block" };







        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void boxerattackevent(object sender, EventArgs e)
        {

            index = random.Next(0, enemyAttack.Count);

            switch (enemyAttack[index].ToString())
            {
                case "left":
                    Boxer.Image = Properties.Resources.enemy_punch1;
                    enemyblock = false; 
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerblock == false)
                    {
                        playerHealth -= 20; 
                    }
                    
                    break;

                case "right ":
                    Boxer.Image = Properties.Resources.enemy_punch2;
                    enemyblock = false;
                    if (Boxer.Bounds.IntersectsWith(Player.Bounds) && playerblock == false)
                    {
                        playerHealth -= 20;
                    }


                    break;
                    Boxer.Image = Properties.Resources.enemy_block;
                    enemyblock = true;


                case "block":

                break;

 
            }


        }

        private void boxermovetimereEvent(object sender, EventArgs e)
        {

            if(playerHealth > 1 )
            {
                BoxerHealthBar.Value = playerHealth;
                

            }

            if (enemyHealth > 1)
            {
                EnemyBar.Value = enemyHealth;

            }




            Boxer.Left += enemySpeed;

            if(Boxer.Left > 430)
            {
                enemySpeed = -5;

            }
             
            if (Boxer.Left < 220)
            {
                enemySpeed = 5;
            }

            if(enemyHealth < 1)
            {
                boxerattacktimer.Stop();
                boxermovetimer.Stop();
                MessageBox.Show("YOU WIN , CLICK OK TO PLAY AGAIN");

                ResetGame();
            }

            if (playerHealth < 1)
            {
                boxerattacktimer.Stop();
                boxermovetimer.Stop();
                MessageBox.Show("  Enemy  WIN , CLICK OK TO PLAY AGAIN");

                ResetGame();

            }



        }

        private void keyIsdown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Left)
            {
                Player.Image = Properties.Resources.boxer_left_punch;
                playerblock = false;

                 if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyblock == false)
                {
                    enemyHealth -= 5;
                }
            }

            if ( e.KeyCode == Keys.Right)
            {
                Player.Image = Properties.Resources.boxer_right_punch;
                playerblock = false;

                if (Player.Bounds.IntersectsWith(Boxer.Bounds) && enemyblock == false)
                {
                    enemyHealth -= 5;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                Player.Image = Properties.Resources.boxer_block;
                playerblock = true;


            }
        }

        private void keyIsup(object sender, KeyEventArgs e)
        {
                Player.Image = Properties.Resources.boxer_stand;
            playerblock = false;


        }

        private void ResetGame()
        {
            boxerattacktimer.Start();
            boxermovetimer.Start();
            playerHealth = 100;
            enemyHealth = 100;

            Boxer.Left = 400;
        }
    }
}