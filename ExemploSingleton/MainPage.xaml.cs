using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ExemploSingleton.Resources;

namespace ExemploSingleton
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Ativa(object sender, RoutedEventArgs e)
        {
            ExemploSingleton.MainPage.Singleton singleton = null;

                    singleton = Singleton.getInstancia();
            
        }


        //public static void main(string[] args)
        //{
        //    ExemploSingleton.MainPage.Singleton singleton = null;

        //    for (int i = 0; i < 100000; i++)
        //    {
        //        singleton = Singleton.getInstancia();
        //    }
        //}





        public class Singleton{
        

            private Singleton(){

            }

            private static Singleton instancia = null;

            public static Singleton getInstancia()
            {
                if(instancia ==null){
                    MessageBox.Show("Instancia Criada ...");
                    instancia = new Singleton();
                }
                else
                {
                    MessageBox.Show("Singleton Não permite mais de uma Instância.");
                }
                return instancia;
            }

            public static Singleton InstanciaNull()
            {
                if (instancia != null)
                {
                    MessageBox.Show("Instancia Apagada ...");
                    instancia = null;
                }
                else
                {
                    MessageBox.Show("Não Existe Instancia Criada.");
                }
                return instancia;
                
            }

        }




        private void Desativa(object sender, RoutedEventArgs e)
        {
            ExemploSingleton.MainPage.Singleton singleton = null;

            singleton = Singleton.InstanciaNull();
        }

        

       

  
    }
}