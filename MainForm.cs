/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 10/1/2024
 * Time: 5:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalClock
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			g = this.panel1.CreateGraphics();
		}
		
		public Graphics g;
		
		public Pen p = new Pen(Color.FromArgb(255,0,0,0),1);
		public Brush b = new SolidBrush(Color.Black);
		
		public Pen pz = new Pen(Color.FromArgb(0,0,0,0),1);
		public Brush bz = new SolidBrush(Color.Gray);
		
		public Pen ps = new Pen(Color.FromArgb(90,0,0,0),3);
		public Brush bs = new SolidBrush(Color.LightGray);
		
		//		uh
		//	ulv		urv
		//		mh
		//  dlv		drv
		//		dh
		
		//	0	uh ulv dlv dh urv drv
		//	1	urv drv
		//	2	uh urv mh dlv dh
		//	3	uh urv mh drv dh
		//	4	ulv mh urv drv
		//	5   uh ulv mh drv dh
		//	6   uh ulv mh drv dh dlv
		//	7	uh urv drv
		//	8	uh ulv dlv dh urv drv mh
		//	9	uh ulv dh urv drv mh	
		//	null	
		
		public void drawuh()
		{
			//draw upper horiz line 
			//uh
			g.DrawRectangle(p,40,10,110,30);
				g.FillRectangle(b,40,10,110,30);
		}
		
		public void drawmh()
		{
			//draw middle horiz line
			//mh			
			g.DrawRectangle(p,40,170,110,30);
				g.FillRectangle(b,40,170,110,30);
		}
		
		public void drawdh()
		{
			//draw down horiz line
			//dh			
			g.DrawRectangle(p,40,330,110,30);
				g.FillRectangle(b,40,330,110,30);
		}
		
		public void drawulv()
		{
			//draw upper left vert line
			//ulv			
			g.DrawRectangle(p,10,40,30,130);
				g.FillRectangle(b,10,40,30,130);
		}
		
		public void drawdlv()
		{
			//draw down left vert line
			//dlv			
			g.DrawRectangle(p,10,200,30,130);
				g.FillRectangle(b,10,200,30,130);
		}
		
		public void drawurv()
		{
			//draw upper right vert line 
			//urv
			g.DrawRectangle(p,150,40,30,130);
				g.FillRectangle(b,150,40,30,130);
		}
		
		public void drawdrv()
		{
			//draw down right vert line
			//drv			
			g.DrawRectangle(p,150,200,30,130);
				g.FillRectangle(b,150,200,30,130);
		}
		public void drawall()
		{
			//H
			//draw upper horiz line 
			//uh
			g.DrawRectangle(p,40,10,110,30);
				g.FillRectangle(b,40,10,110,30);
			//draw middle horiz line
			//mh			
			g.DrawRectangle(p,40,170,110,30);
				g.FillRectangle(b,40,170,110,30);
			//draw down horiz line
			//dh			
			g.DrawRectangle(p,40,330,110,30);
				g.FillRectangle(b,40,330,110,30);
			//V
			//draw upper left vert line
			//ulv			
			g.DrawRectangle(p,10,40,30,130);
				g.FillRectangle(b,10,40,30,130);
			//draw down left vert line
			//dlv			
			g.DrawRectangle(p,10,200,30,130);
				g.FillRectangle(b,10,200,30,130);
			//draw upper right vert line 
			//urv
			g.DrawRectangle(p,150,40,30,130);
				g.FillRectangle(b,150,40,30,130);
			//draw down right vert line
			//drv			
			g.DrawRectangle(p,150,200,30,130);
				g.FillRectangle(b,150,200,30,130);
		}
		public void draw0()
		{
			clearscreen();
			drawshadow();
			drawuh();
			drawulv();
			drawdlv();
			drawdh();
			drawurv();
			drawdrv();
			
		}
		public void draw1()
		{
			clearscreen();
			drawshadow();
			drawurv();
			drawdrv();
		}
		public void draw2()
		{
			clearscreen();
			drawshadow();
			drawuh();
			drawurv();
			drawmh();
			drawdlv();
			drawdh();
		}
		public void draw3()
		{
			clearscreen();
			drawshadow();
			drawuh();
			drawurv();
			drawmh();
			drawdrv();
			drawdh();
		}
		public void draw4()
		{
			clearscreen();
			drawshadow();
			drawulv();
			drawmh();
			drawurv();
			drawdrv();
			
		}
		public void draw5()
		{
			clearscreen();
			drawshadow();
			drawuh();
			drawulv();
			drawmh();
			drawdrv();
			drawdh();
		}
		public void draw6()
		{
			clearscreen();
			drawshadow();
			drawuh();
			drawulv();
			drawmh();
			drawdrv();
			drawdh();
			drawdlv();
		}
		public void draw7()
		{
			clearscreen();
			drawshadow();
			drawuh(); 
			drawurv(); 
			drawdrv();
		}
		
		public void draw8()
		{
			clearscreen();
			drawshadow();
			drawuh(); 
			drawulv(); 
			drawdlv(); 
			drawdh(); 
			drawurv(); 
			drawdrv(); 
			drawmh();
		}
		public void draw9()
		{
			clearscreen();
			drawshadow();
			drawuh(); 
			drawulv(); 
			drawdh(); 
			drawurv(); 
			drawdrv(); 
			drawmh();
		}
		
		public void drawnull()
		{
			clearscreen();
			drawshadow();
			//H
			//draw upper horiz line 
			//uh
			g.DrawRectangle(pz,40,10,110,30);
				g.FillRectangle(bz,40,10,110,30);
			//draw middle horiz line
			//mh			
			g.DrawRectangle(pz,40,170,110,30);
				g.FillRectangle(bz,40,170,110,30);
			//draw down horiz line
			//dh			
			g.DrawRectangle(pz,40,330,110,30);
				g.FillRectangle(bz,40,330,110,30);
			//V
			//draw upper left vert line
			//ulv			
			g.DrawRectangle(pz,10,40,30,130);
				g.FillRectangle(bz,10,40,30,130);
			//draw down left vert line
			//dlv			
			g.DrawRectangle(pz,10,200,30,130);
				g.FillRectangle(bz,10,200,30,130);
			//draw upper right vert line 
			//urv
			g.DrawRectangle(pz,150,40,30,130);
				g.FillRectangle(bz,150,40,30,130);
			//draw down right vert line
			//drv			
			g.DrawRectangle(pz,150,200,30,130);
				g.FillRectangle(bz,150,200,30,130);
		}
		
		public void drawshadow()
		{
			//clearscreen();
			//H
			//draw upper horiz line 
			//uh
			g.DrawRectangle(ps,40,10,110,30);
				g.FillRectangle(bs,40,10,110,30);
			//draw middle horiz line
			//mh			
			g.DrawRectangle(ps,40,170,110,30);
				g.FillRectangle(bs,40,170,110,30);
			//draw down horiz line
			//dh			
			g.DrawRectangle(ps,40,330,110,30);
				g.FillRectangle(bs,40,330,110,30);
			//V
			//draw upper left vert line
			//ulv			
			g.DrawRectangle(ps,10,40,30,130);
				g.FillRectangle(bs,10,40,30,130);
			//draw down left vert line
			//dlv			
			g.DrawRectangle(ps,10,200,30,130);
				g.FillRectangle(bs,10,200,30,130);
			//draw upper right vert line 
			//urv
			g.DrawRectangle(ps,150,40,30,130);
				g.FillRectangle(bs,150,40,30,130);
			//draw down right vert line
			//drv			
			g.DrawRectangle(ps,150,200,30,130);
				g.FillRectangle(bs,150,200,30,130);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			clearscreen();
			draw8();
		}
		
		public void clearscreen()
		{
			g.Clear(this.panel1.BackColor);
		}
		void Button3Click(object sender, EventArgs e)
		{
			clearscreen();
		}
		void Button2Click(object sender, EventArgs e)
		{
			drawnull();
		}
		void Button4Click(object sender, EventArgs e)
		{
			clearscreen();
			draw0();
		}
		void Button5Click(object sender, EventArgs e)
		{
			clearscreen();
			draw1();
			
		}
		void Button6Click(object sender, EventArgs e)
		{
			clearscreen();
			draw2();
		}
		void Button7Click(object sender, EventArgs e)
		{
			clearscreen();
			draw3();
		}
		void Button8Click(object sender, EventArgs e)
		{
			clearscreen();
			draw4();
		}
		void Button9Click(object sender, EventArgs e)
		{
			clearscreen();
			draw5();
		}
		void Button10Click(object sender, EventArgs e)
		{
			clearscreen();
			draw6();
		}
		void Button11Click(object sender, EventArgs e)
		{
			clearscreen();
			draw7();
		}
		void Button12Click(object sender, EventArgs e)
		{
			clearscreen();
			draw9();
		}
		void Button13Click(object sender, EventArgs e)
		{
			clearscreen();
			drawall();
		}
		void Button14Click(object sender, EventArgs e)
		{
			//clearscreen();
			drawshadow();
		}
	}
}
