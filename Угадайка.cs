using System;
using System.Diagnostics;
using System.Windows.Forms;

class Script
{
    [STAThread]
    static public void Main(string[] args)
    {

		Random rand = new Random();
		int b=rand.Next(1,8);
		int.TryParse(Console.ReadLine(), out int a);
		  int count=1;
		  while(count<=8)
		  {
			  if(b==a)
			  {
				Console.WriteLine("Yeah, you right");				
			 
			  break;
			  }
			  else
			  {
				  count++;
				  if(count==6)
				  {
					  Console.WriteLine("Sorry bro.Game over");
					  
					  break;
				  }
				  Console.WriteLine("Hey bro, try again. Try ="+count);
				  int.TryParse(Console.ReadLine(), out int a);
				  
			  }
			  
		  } 
		  Console.ReadLine();
    }
}