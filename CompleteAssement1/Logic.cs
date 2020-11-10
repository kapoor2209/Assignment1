using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public class LogicClass
    {
                              int Ammo = 0;
                               int Possibility = 2;

  public void FarShootingBtn()
{
               if (Possibility > 0)
{
                if (Ammo == 5)
{           
                    MessageBox.Show("You survived . \nYour Score : " + Ammo+ (Ammo ==5 ?"\n \n You Gain" : "\n You failure"));
                                              }
                else
  {
                          MessageBox.Show("Reload your gun");
                         Ammo = Ammo + 1;
                                                                         }               
                               }          
            else
{
                    MessageBox.Show("Dead! Game Over");
                                                                              }
Possibility = Possibility - 1;
                                                                            }



        public void ShootingBtn()

{
                      if (Ammo == 5)

            {
                MessageBox.Show("Dead! Game Over");
            }
            else
            {
                MessageBox.Show("Shoting gun");

                Ammo = Ammo + 1;
                                }
                            }


public void GunRotateBtn()
    
{
                  Random rand = new Random();

                   Ammo = rand.Next(0, 6);

                   MessageBox.Show(" Spin Your Gun");

               }


    public void Retrybtn()
        {

            Ammo = 0;
            Possibility = 2;
            MessageBox.Show("Start Your Game");

                                                 }
        public void ReloadingBtn()
       
{
                     Ammo = 0;
                 MessageBox.Show("Load your Gun");
                                                    }
   }
}
