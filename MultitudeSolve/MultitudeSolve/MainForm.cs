using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultitudeSolve
{
    public interface IMainForm
    {
        string[] Content { get;}
        string[] Content_2 { get; }

        string[] Content_3 { get; }

        string[] Content_4 { get; }

        string[] Content_5 { get; }
        string[] RelationContent { get; }
        string ResultContent { get; set; }
        bool CheckUniversal { get; }

        bool CheckFirstMultitude { get; }
        bool CheckSecondMultitude { get; }

        bool CheckRelation { get; }

        bool CkeckFirstRelation { get; }
        bool CkeckSecondRelation { get; }

        event EventHandler SolveDifference;
        event EventHandler SolveAssociation;
        event EventHandler SolveAddress;
        event EventHandler SolveSymetricDifference;
        event EventHandler SolveCartesianWork;
        event EventHandler SolveAddition;
        event EventHandler SolveComposition;
        event EventHandler SolveCrossing;
    }
    public partial class MainForm : Form, IMainForm
    {
        
        public MainForm()
        {
            InitializeComponent();
            ButDifference.Click += ButDifference_Click;
            ButAddition.Click += ButAddition_Click;
            ButAddress.Click += ButAddress_Click;
            ButAssociation.Click += ButAssociation_Click;
            ButCartesianWork.Click += ButCartesianWork_Click;
            ButComposition.Click += ButComposition_Click;
            ButCrossing.Click += new EventHandler(ButCrossing_Click);
            ButSymetricDifference.Click += ButSymetricDifference_Click;
        }



        private void ButSymetricDifference_Click(object sender, EventArgs e)
        {
            if (SolveSymetricDifference != null)
            {
                Result.Clear();
                Result.Clear(); SolveSymetricDifference(this, EventArgs.Empty);
            }
        }

        void ButCrossing_Click(object sender, EventArgs e)
        {
            if (SolveCrossing != null)
            {
                Result.Clear();
                SolveCrossing(this, EventArgs.Empty);
            }
        }

        private void ButComposition_Click(object sender, EventArgs e)
        {
            if (SolveComposition != null)
            {
                Result.Clear();
                SolveComposition(this, EventArgs.Empty);
            }
        }

        private void ButCartesianWork_Click(object sender, EventArgs e)
        {
            if (SolveCartesianWork != null)
            {
                Result.Clear();
                SolveCartesianWork(this, EventArgs.Empty);
            }
        }

        private void ButAssociation_Click(object sender, EventArgs e)
        {
            if (SolveAssociation != null)
            {
                Result.Clear();
                SolveAssociation(this, EventArgs.Empty);
            }
        }

        private void ButAddress_Click(object sender, EventArgs e)
        {
            if (SolveAddress != null)
            {
                Result.Clear();
                SolveAddress(this, EventArgs.Empty);
            }
        }

        private void ButAddition_Click(object sender, EventArgs e)
        {
            if (SolveAddition != null)
            {
                Result.Clear();
                SolveAddition(this, EventArgs.Empty);
            }
        }

        public event EventHandler SolveDifference;
        public event EventHandler SolveAssociation;
        public event EventHandler SolveAddress;
        public event EventHandler SolveSymetricDifference;
        public event EventHandler SolveCartesianWork;
        public event EventHandler SolveAddition;
        public event EventHandler SolveComposition;
        public event EventHandler SolveCrossing;

        private void ButDifference_Click(object sender, EventArgs e)
        {
            if (SolveDifference != null)
            {
                Result.Clear();
                SolveDifference(this, EventArgs.Empty);
            }
        }

        public string ResultContent
        {
            get { return Result.Text; }
            set { Result.Text = value; }
        }
        

        public string[] Content
        {
            get
            {
                return FirstMultitude.Text.Split(new char[] { ',' });
            }
        }

        public string[] Content_2
        {
            get
            {
                return SecondMultitude.Text.Split(new char[] { ',' });
            }
        }

        public string[] Content_3
        {
            get
            {
                return Universal.Text.Split(new char[] { ',' });
            }
        }

        public string[] Content_4
        {
            get
            {

                string result;
                result = FirstRelation.Text;
                result = result.Replace("(", "");
                result = result.Replace(")", "");
                return result.Split(new char[] { ',' });

            }
        }

        public string[] Content_5
        {
            get
            {
                string result;
                result = SecondRelation.Text;
                result = result.Replace("(", "");
                result = result.Replace(")", "");
                return result.Split(new char[] { ','});
            }
        }
        public string[] RelationContent
        {
            get
            {
                return SecondMultitude.Text.Split(';');
            }
        }

        public bool CheckUniversal
        {
            get
            {
                if (UniversalCHeck.Checked)
                {
                    return true;
                }
                else return false;
            }
        }

        private void UniversalCHeck_CheckedChanged(object sender, EventArgs e)
        {
            if (UniversalCHeck.Checked) Universal.ReadOnly = false;
            else
            {
                Universal.Clear();
                Universal.ReadOnly = true;
            }
        }

        public bool CheckFirstMultitude
        {
            get
            {
                if (FirstMultitude.Text.Length == 0)
                    return false;
                else return true;
            }
        }

        public bool CheckSecondMultitude
        {
            get
            {
                if (SecondMultitude.Text.Length == 0)
                    return false;
                else return true;
            }
        }

        public bool CheckRelation
        {
            get
            {
                if (FirstRelation.Text.Length == 0 && SecondRelation.Text.Length == 0)
                    return false;
                else return true;
            }
        }

        public bool CkeckFirstRelation
        {
            get
            {
                if (FirstRelation.Text.Length != 0)
                    return true;
                else return false;
            }
        }

        public bool CkeckSecondRelation
        {
            get
            {
                if (SecondRelation.Text.Length != 0)
                    return true;
                else return false;
            }
        }
    }
}
