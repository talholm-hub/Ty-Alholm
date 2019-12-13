using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project8
{
    public enum PieceColor { empty, red, black};
    PieceColor col = PieceColor.black;
    public partial class Board : Form
    {
        public Board()
        {
            InitializeComponent();
        }
        public PieceColor Turn
        {

        }
        public PieceColor GetColor(int x,int y)
        {

        }

        public bool isWinner(PieceColor player)
        {

        }

        public bool CheckTie()
        {

        }

        public void SwitchTurns()
        {

        }

        public bool Move(int col)
        {

        }

        }
    }

