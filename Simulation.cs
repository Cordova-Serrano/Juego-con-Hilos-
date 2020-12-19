using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Simulation_Threads
{
    public partial class Simulation : Form
    {
        //Atributo para la salud del tanque
        int statusHealth = 5;
        //Atributos para el movimiento del tanque
        bool moveUp = false;
        bool moveDown = false;
        bool moveLeft = false;
        bool moveRight = false;
        int speed = 30;
        //Atributos para la bala
        int speedBullet = 20;
        int contBullets;
        //Atributos para el movimiento del enemigo
        bool enemyL = false;
        int speedEnemy = 10;
        bool enemyBulletMov = true;
        //Banderas para los hilos
        bool canMove = true;
        bool canFire = true;
        bool fire = false;
        bool enemyCanMove = true;
        bool ammoEmpty = false;
        //Delegados
        Action delegado;
        public Simulation()
        {
            InitializeComponent();
        }
        private void Simulation_Load(object sender, EventArgs e)
        {
            //Cantidad de balas
            contBullets = 4;
            //Threads
            Thread moveTank = new Thread(MovementTank); //Hilo para el movimiento del tanque
            Thread moveEnemy = new Thread(MovementEnemy); //Hilos para el movimiento del tanque
            Thread enemyBullet = new Thread(EnemyBullet); //Hilo para el ataque enemigo
            //Start Threads
            moveTank.Start();
            moveEnemy.Start();
            enemyBullet.Start();
        }
        public void MovementTank()
        {
            while (canMove)
            {
                if (moveLeft == true && tank.Left > 0)
                {
                    delegado = () => tank.Left -= speed;
                    Invoke(delegado);
                    Thread.Sleep(300);
                }
                if (moveRight == true && tank.Left < 1210)
                {
                    delegado = () => tank.Left += speed;
                    Invoke(delegado);
                    Thread.Sleep(300);
                }
                if (moveUp == true && tank.Top > 0)
                {
                    delegado = () => tank.Top -= speed;
                    Invoke(delegado);
                    Thread.Sleep(300);
                }
                if (moveDown == true && tank.Top < 630)
                {
                    delegado = () => tank.Top += speed;
                    Invoke(delegado);
                    Thread.Sleep(300);
                }
            }
        }
        public void MovementEnemy()
        {
            while (enemyCanMove)
            {
                if (enemyL)
                {
                    delegado = () => enemy.Left += speedEnemy;
                    Invoke(delegado);
                    Thread.Sleep(50);
                }
                else
                {
                    delegado = () => enemy.Left -= speedEnemy;
                    Invoke(delegado);
                    Thread.Sleep(50);
                }
                //Movimiento en X
                if (enemy.Left <= 0)
                {
                    enemyL = true;
                }
                if (enemy.Left >= this.Width - 100)
                {
                    enemyL = false;
                }
            }
        }
        public void EnemyBullet()
        {
            while (enemyBulletMov)
            {
                delegado = () => bulletEnemy.Top += speedBullet;
                Invoke(delegado);
                Thread.Sleep(100);

                if (bulletEnemy.Location.Y > 800)
                {
                    Random y = new Random();

                    Invoke(delegado);

                    delegado = () => bulletEnemy.Location = new Point(y.Next(this.Width - 300), -200);
                    Invoke(delegado);
                }
                if (bulletEnemy.Location.X < tank.Location.X + tank.Width && tank.Location.X < bulletEnemy.Location.X + bulletEnemy.Width)
                {
                    if (bulletEnemy.Location.Y < tank.Location.Y + tank.Height && tank.Location.Y < bulletEnemy.Location.Y + bulletEnemy.Height)
                    {
                        Random y = new Random();

                        Invoke(delegado);

                        delegado = () => bulletEnemy.Location = new Point(y.Next(this.Width - 300), -200);
                        Invoke(delegado);

                        statusHealth--;
                        Thread status = new Thread(StatusHUD);
                        status.Start();
                    }

                }
            }
        }
        public void MovBullet()
        {
            Console.WriteLine("Firing");
            Console.WriteLine("fire = " + fire);
            while (fire)
            {

                delegado = () => bullet1.Top -= speedBullet;
                Invoke(delegado);
                Thread.Sleep(300);

                canFire = false;

                if (bullet1.Location.Y < -138)
                {
                    fire = false;

                    delegado = () => bullet1.Visible = false;
                    Invoke(delegado);

                    delegado = () => bullet1.Location = new Point(0, 500);
                    Invoke(delegado);

                    canFire = true;
                }
                if (bullet1.Location.X < enemy.Location.X + enemy.Width && enemy.Location.X < bullet1.Location.X + bullet1.Width)
                {
                    if (bullet1.Location.Y < enemy.Location.Y + enemy.Height && enemy.Location.Y < bullet1.Location.Y + bullet1.Height)
                    {
                        Random y = new Random();

                        delegado = () => bullet1.Visible = false;
                        Invoke(delegado);

                        delegado = () => bullet1.Location = new Point(0, 500); //regresa a su lugar de origen
                        Invoke(delegado);

                        enemyCanMove = false;

                        delegado = () => enemy.Image = Image.FromFile(Application.StartupPath + "/TankEnemyDeath.png");
                        Invoke(delegado);

                        Thread.Sleep(1000);
                        Win();
                    }

                }
            }
        }
        public void Reloading()
        {
            Console.WriteLine("Reloading");
            while (ammoEmpty)
            {
                //Recargar municion
                Thread.Sleep(1000); //Se espera 1 segundo en lo que se recarga la bala 
                delegado = () => ammoHUD.Image = Image.FromFile(Application.StartupPath + "/1 - 4.jpg");
                Invoke(delegado);
                contBullets++;
                Console.WriteLine("Reloade |1 - 4| : " + contBullets);

                Thread.Sleep(1000); //Se espera 1 segundo en lo que se recarga la bala
                delegado = () => ammoHUD.Image = Image.FromFile(Application.StartupPath + "/2 - 4.jpg");
                Invoke(delegado);
                contBullets++;
                Console.WriteLine("Reloade |2 - 4| : " + contBullets);

                Thread.Sleep(1000); //Se espera 1 segundo en lo que se recarga la bala
                delegado = () => ammoHUD.Image = Image.FromFile(Application.StartupPath + "/3 - 4.jpg");
                Invoke(delegado);
                contBullets++;
                Console.WriteLine("Reloade |3 - 4| : " + contBullets);

                Thread.Sleep(1000); //Se espera 1 segundo en lo que se recarga la bala
                delegado = () => ammoHUD.Image = Image.FromFile(Application.StartupPath + "/4 - 4.jpg");
                Invoke(delegado);
                contBullets++;
                Console.WriteLine("Reloade |4 - 4| : " + contBullets);

                if (contBullets == 4)
                {
                    Console.WriteLine("Ammo Full");
                    ammoEmpty = false;
                }
            }

        }
        public void AmmoHUDstatus(int cont)
        {
            if (cont == 3) //Cargador 3 - 4 
            {
                ammoHUD.Image = Image.FromFile(Application.StartupPath + "/3 - 4.jpg");
            }
            if (cont == 2) //Cargador 2 - 4 
            {
                ammoHUD.Image = Image.FromFile(Application.StartupPath + "/2 - 4.jpg");
            }
            if (cont == 1) //Cargador 1 - 4 
            {
                ammoHUD.Image = Image.FromFile(Application.StartupPath + "/1 - 4.jpg");
            }
            if (cont == 0) //Cargador 0 - 4 
            {
                ammoHUD.Image = Image.FromFile(Application.StartupPath + "/0 - 4.jpg");
            }
        }
        public void StatusHUD()
        {
            if (statusHealth == 5) //Vida al 100
            {
                delegado = () => statusHUD.Image = Image.FromFile(Application.StartupPath + "/bar-100.png");
                Invoke(delegado);
            }
            if (statusHealth == 4) //Vida al 75
            {
                //Cambia el tamaño
                delegado = () => statusHUD.Size = new System.Drawing.Size(360, 18);
                Invoke(delegado);
                //Cambio de imagen
                delegado = () => statusHUD.Image = Image.FromFile(Application.StartupPath + "/bar-75.png");
                Invoke(delegado);
            }
            if (statusHealth == 3) //Vida al 50
            {
                //Reduccion de velocidad
                speed = (speed / 2);
                delegado = () => speedHUD.Image = Image.FromFile(Application.StartupPath + "/speedHUD50.jpg");
                Invoke(delegado);
                //Cambia el tamaño
                delegado = () => statusHUD.Size = new System.Drawing.Size(240, 18);
                Invoke(delegado);
                //Cambio de imagen
                delegado = () => statusHUD.Image = Image.FromFile(Application.StartupPath + "/bar-50.png");
                Invoke(delegado);
            }
            if (statusHealth == 2) //Vida al 25
            {
                //Cambia el tamaño
                delegado = () => statusHUD.Size = new System.Drawing.Size(120, 18);
                Invoke(delegado);
                //Cambio de imagen
                delegado = () => statusHUD.Image = Image.FromFile(Application.StartupPath + "/bar-25.png");
                Invoke(delegado);
            }
            if (statusHealth == 1) //Vida al 0
            {
                //Cambia la imagen del tanque
                delegado = () => tank.Image = Image.FromFile(Application.StartupPath + "/TanqueLose.png");
                Invoke(delegado);
                //Cambian los bool
                canMove = false; //El tanque ya no puede moverse
                canFire = false; //El tanque ya no puede disparar
                //Cambia el tamaño
                delegado = () => statusHUD.Size = new System.Drawing.Size(480, 18);
                Invoke(delegado);
                //Cambio de imagen
                delegado = () => statusHUD.Image = Image.FromFile(Application.StartupPath + "/bar-0.png");
                Invoke(delegado);
                //Enemigo se deja de mover
                enemyBulletMov = false;
                Thread.Sleep(2000);

                Lose(); //Términa el juego 
            }
        }
        public void Lose()
        {
            delegado = () => youLose.Visible = true;
            Invoke(delegado);

            delegado = () => retryBtn.Visible = true;
            Invoke(delegado);

            delegado = () => exitBtn.Visible = true;
            Invoke(delegado);
        }
        public void Win()
        {
            WinScreen end = new WinScreen();

            delegado = () => end.Show(this);
            Invoke(delegado);

            delegado = () => this.Hide();
            Invoke(delegado);

        }
        private void Simulation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {

                    moveLeft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = true;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = true;
            }
            //Disparar
            if (canFire)
            {
                if (e.KeyCode == Keys.F)
                {
                    Console.WriteLine("fire = " + fire);
                    //Se dispara la bala
                    fire = true;
                    //Mostrar la bala
                    bullet1.Visible = true;
                    //Bala posicion
                    bullet1.Location = new Point(tank.Location.X + 50, tank.Location.Y - 115);
                    Console.WriteLine("fire = " + fire);
                    //Se crea el hilo
                    Thread bulletTank = new Thread(MovBullet); //Hilo para el proyectil del tanque
                    bulletTank.Start();
                    //Descontando la bala disparada
                    contBullets--;
                    AmmoHUDstatus(contBullets);
                    //Condicion para declarar que ya no hay municion 
                    if (contBullets == 0)
                        ammoEmpty = true;
                    //Condicion para recargar
                    if (ammoEmpty)
                    {
                        Thread ammo = new Thread(Reloading); //Hilo para la municion
                        ammo.Start();
                    }
                    Console.WriteLine("contBullets : " + contBullets);
                }
            }
        }
        private void Simulation_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
            if (e.KeyCode == Keys.S)
            {
                moveDown = false;
            }
            if (e.KeyCode == Keys.W)
            {
                moveUp = false;
            }
        }

        private void exitBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void retryBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show(this);
            this.Hide();
        }
    }

}

