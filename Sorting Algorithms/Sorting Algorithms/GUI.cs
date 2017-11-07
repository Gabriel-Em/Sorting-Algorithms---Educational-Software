using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Algorithms
{
    public partial class GUI : Form
    {
        private Controller ctrl;
        private int Step;
        private string CurrentStep;
        private int SortIndex;

        /* 
        * 0 - Bubble Sort
        * 1 - Insertion Sort
        * 2 - Selection Sort
        * 3 - Count Sort
        * 4 - Merge Sort
        * 5 - Bubble Sort 
        */

        public GUI()
        {
            InitializeComponent();
            ctrl = new Controller(this);
            SortIndex = -1;
        }

        private void btnPickAlgorithm(object sender, EventArgs e)
        {
            if (SortIndex != -1)
                Reset();

            ctrl.newList(txtList.Text);
            Button btn = (Button)sender;

            switch (btn.Name)
            {
                case "btnBubble": changeAndCenterTitle("Bubble Sort"); SortIndex = 0; break;
                case "btnInsertion": changeAndCenterTitle("Insertion Sort"); SortIndex = 1; break;
                case "btnSelection": changeAndCenterTitle("Selection Sort"); SortIndex = 2; break;
                case "btnCount": changeAndCenterTitle("Count Sort"); SortIndex = 3; break;
                case "btnMerge": changeAndCenterTitle("Merge Sort"); SortIndex = 4; break;
                case "btnQuick": changeAndCenterTitle("Quick Sort"); SortIndex = 5; break;
            }
            btnNext.Enabled = true;
            initAlgorithm();
        }

        private void changeAndCenterTitle(string title)
        {
            labelTitle.Text = title;
            labelTitle.Location = new Point(panelAnimation.Width / 2 - labelTitle.Width / 2, 0);
        }
        private void initAlgorithm()
        {
            switch(SortIndex)
            {
                case 0:
                    for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                    {
                        panelAnimation.Controls.Add(ctrl.Lista.VisualElements[i].Block);
                        ctrl.Lista.VisualElements[i].Value.BringToFront();
                        ctrl.Lista.VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.Lista.VisualElements.Count + 12 * (ctrl.Lista.VisualElements.Count - 1))) / 2 + i * (ctrl.Lista.VisualElements[i].Block.Width + 12), 100 + ctrl.Lista.VisualElements[i].Location.Y);

                        AttachmentElement EA = new AttachmentElement(i.ToString());
                        ctrl.ListaAtasamente.add(EA);
                        panelAnimation.Controls.Add(EA.Attachment);
                        EA.setLocation(ctrl.Lista.VisualElements[i].Block.Location, 1);
                    }

                    AttachmentElement AE = new AttachmentElement("S");
                    ctrl.ListaAtasamente.add(AE);
                    panelAnimation.Controls.Add(AE.Attachment);
                    AE.setAsArrayName(ctrl.Lista.VisualElements[0].Block.Location);

                    rchCode.Text = System.IO.File.ReadAllText(@".\Algorithms\BubbleSort.txt");
                    ctrl.BubbleSort();
                    break;

                case 1:
                    for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                    {
                        panelAnimation.Controls.Add(ctrl.Lista.VisualElements[i].Block);
                        ctrl.Lista.VisualElements[i].Value.BringToFront();
                        ctrl.Lista.VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.Lista.VisualElements.Count + 12 * (ctrl.Lista.VisualElements.Count - 1))) / 2 + i * (ctrl.Lista.VisualElements[i].Block.Width + 12), 100 + ctrl.Lista.VisualElements[i].Location.Y);

                        AttachmentElement EA = new AttachmentElement(i.ToString());
                        ctrl.ListaAtasamente.add(EA);
                        panelAnimation.Controls.Add(EA.Attachment);
                        EA.setLocation(ctrl.Lista.VisualElements[i].Block.Location, 1);
                    }

                    AE = new AttachmentElement("S");
                    ctrl.ListaAtasamente.add(AE);
                    panelAnimation.Controls.Add(AE.Attachment);
                    AE.setAsArrayName(ctrl.Lista.VisualElements[0].Block.Location);

                    rchCode.Text = System.IO.File.ReadAllText(@".\Algorithms\InsertionSort.txt");
                    ctrl.InsertionSort();
                    break;

                case 2:
                    for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                    {
                        panelAnimation.Controls.Add(ctrl.Lista.VisualElements[i].Block);
                        ctrl.Lista.VisualElements[i].Value.BringToFront();
                        ctrl.Lista.VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.Lista.VisualElements.Count + 12 * (ctrl.Lista.VisualElements.Count - 1))) / 2 + i * (ctrl.Lista.VisualElements[i].Block.Width + 12), 100 + ctrl.Lista.VisualElements[i].Location.Y);

                        AttachmentElement EA = new AttachmentElement(i.ToString());
                        ctrl.ListaAtasamente.add(EA);
                        panelAnimation.Controls.Add(EA.Attachment);
                        EA.setLocation(ctrl.Lista.VisualElements[i].Block.Location, 1);
                    }

                    AE = new AttachmentElement("S");
                    ctrl.ListaAtasamente.add(AE);
                    panelAnimation.Controls.Add(AE.Attachment);
                    AE.setAsArrayName(ctrl.Lista.VisualElements[0].Block.Location);

                    rchCode.Text = System.IO.File.ReadAllText(@".\Algorithms\SelectionSort.txt");
                    ctrl.SeletionSort();
                    break;

                case 3:
                    for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                    {
                        panelAnimation.Controls.Add(ctrl.Lista.VisualElements[i].Block);
                        ctrl.Lista.VisualElements[i].Value.BringToFront();
                        ctrl.Lista.VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.Lista.VisualElements.Count + 12 * (ctrl.Lista.VisualElements.Count - 1))) / 2 + i * (ctrl.Lista.VisualElements[i].Block.Width + 12), 100 + ctrl.Lista.VisualElements[i].Location.Y);

                        AttachmentElement EA = new AttachmentElement(i.ToString());
                        ctrl.ListaAtasamente.add(EA);
                        panelAnimation.Controls.Add(EA.Attachment);
                        EA.setLocation(ctrl.Lista.VisualElements[i].Block.Location, 1);
                    }

                    AE = new AttachmentElement("S");
                    ctrl.ListaAtasamente.add(AE);
                    panelAnimation.Controls.Add(AE.Attachment);
                    AE.setAsArrayName(ctrl.Lista.VisualElements[0].Block.Location);

                    rchCode.Text = System.IO.File.ReadAllText(@".\Algorithms\CountSort.txt");
                    ctrl.CountSort();
                    break;
            }

            Step = 1;
            CurrentStep = "next";
            executeStep();
        }

        private void executeStep()
        {
            CStep cstep = ctrl.Steps[Step - 1];
            Step step = null;

            if (CurrentStep == "next")
                step = cstep.NextStep;
            else
                step = cstep.PrevStep;

            Highlight(step.Highlight);
            rchExplanation.Text = "Pasul " + Step + ":\n\n" + step.Message;
 
            foreach(string command in step.Command.Split('|'))
                switch (command)
                {
                    case "Attach":
                        int limit;

                        if (step.Delimiter == -1 || step.UseDelimForUpdateInit)
                            limit = step.AttachNames.Count;
                        else
                            limit = step.Delimiter;

                        for(int i =0;i<limit;i++)
                        {
                            int index = ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i]);
                            if (index == -1)
                            {
                                AttachmentElement EA_ = new AttachmentElement(step.AttachNames[i]);
                                ctrl.addAE(EA_);

                                if (step.AttachTo[i] == ctrl.Lista.IntegerElements.Count)
                                {
                                    Point l = new Point(ctrl.Lista.VisualElements[step.AttachTo[i] - 1].Block.Location.X + 52, ctrl.Lista.VisualElements[step.AttachTo[i] - 1].Block.Location.Y);
                                    EA_.setLocation(l, step.Rows[i]);
                                }
                                else
                                    EA_.setLocation(ctrl.Lista.VisualElements[step.AttachTo[i]].Block.Location, step.Rows[i]);
                                panelAnimation.Controls.Add(EA_.Attachment);
                            }
                            else
                            {
                                if (step.AttachTo[i] == ctrl.Lista.IntegerElements.Count)
                                {
                                    Point l = new Point(ctrl.Lista.VisualElements[step.AttachTo[i] - 1].Block.Location.X+52,ctrl.Lista.VisualElements[step.AttachTo[i]-1].Block.Location.Y);
                                    ctrl.ListaAtasamente[ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i])].setLocation(l, step.Rows[i]);
                                }
                                else
                                    ctrl.ListaAtasamente[ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i])].setLocation(ctrl.Lista.VisualElements[step.AttachTo[i]].Block.Location, step.Rows[i]);
                            }
                                
                        }
                        break;
                    case "Detach":
                        if (step.Delimiter == -1 || step.UseDelimForUpdateInit)
                            limit = 0;
                        else
                            limit = step.Delimiter;

                        for (int i = limit; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                            {
                                panelAnimation.Controls.Remove(ctrl.ListaAtasamente[index].Attachment);
                                ctrl.ListaAtasamente[index].Dispose();
                                ctrl.ListaAtasamente.remove(index);
                            }
                        }
                        break;
                    case "Init":
                        if (step.Delimiter == -1)
                            limit = step.VariableIndexes.Count();
                        else
                            limit = step.Delimiter;

                        for (int i = 0; i <limit; i++)
                        {
                            variableDataGridView.Rows.Add();
                            variableDataGridView.Rows[step.VariableIndexes[i]].Cells[0].Value = step.VariableNames[i];
                            variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        }
                        break;
                    case "!Init":
                        if (step.Delimiter == -1)
                            limit = 0;
                        else
                            limit = step.Delimiter;

                        for (int i = limit; i < step.VariableIndexes.Count(); i++)
                            variableDataGridView.Rows.RemoveAt(step.VariableIndexes[i]);
                        break;
                    case "Update":
                        
                        if (step.Delimiter == -1)
                            limit = step.VariableIndexes.Count();
                        else
                            limit = step.Delimiter;

                        if (step.UseDelimForUpdateInit)
                            for (int i = limit; i < step.VariableIndexes.Count(); i++)
                                variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        else
                            for (int i = 0; i < limit; i++)
                                variableDataGridView.Rows[step.VariableIndexes[i]].Cells[1].Value = step.Values[i];
                        break;
                    case "Highlight":
                        for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                            if (step.HighlightedBlockIndexes.Contains(i))
                                ctrl.Lista.VisualElements[i].Block.BackColor = Color.Red;
                            else
                                ctrl.Lista.VisualElements[i].Block.BackColor = Color.Orange;
                        break;
                    case "Swap":
                        SortingElement aux = ctrl.Lista.VisualElements[step.Swit.Item1];
                        ctrl.Lista.VisualElements[step.Swit.Item1] = ctrl.Lista.VisualElements[step.Swit.Item2];
                        ctrl.Lista.VisualElements[step.Swit.Item2] = aux;
                        Point auxLoc = ctrl.Lista.VisualElements[step.Swit.Item1].Location;
                        ctrl.Lista.VisualElements[step.Swit.Item1].Location = ctrl.Lista.VisualElements[step.Swit.Item2].Location;
                        ctrl.Lista.VisualElements[step.Swit.Item2].Location = auxLoc;
                        break;
                    case "IHighlight":
                        for (int i = 0; i < ctrl.Lista.IntegerElements.Count; i++)
                            if (step.HighlightedLabelIndexes.Contains(i))
                                ctrl.ListaAtasamente[i].Attachment.ForeColor = Color.Red;
                            else
                                ctrl.ListaAtasamente[i].Attachment.ForeColor = Color.Black;
                        break;
                    case "AIHighlight":
                        for (int i = ctrl.ExtraAtasamente.Lista.Count-ctrl.Lista.IntegerElements.Count-2; i < ctrl.ExtraAtasamente.Lista.Count-2; i++)
                            if (step.HighlightedLabelIndexes.Contains(i-(ctrl.ExtraAtasamente.Lista.Count-ctrl.Lista.IntegerElements.Count-2)))
                                ctrl.ExtraAtasamente[i].Attachment.ForeColor = Color.Red;
                            else
                                ctrl.ExtraAtasamente[i].Attachment.ForeColor = Color.Black;
                        break;
                    case "AEHighlight":
                        for (int i = 0; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                                ctrl.ListaAtasamente[index].Attachment.ForeColor = Color.Red;
                        }
                        break;
                    case "!AEHighlight":
                        for (int i = 0; i < step.AttachNames.Count; i++)
                        {
                            int index = ctrl.ListaAtasamente.getIndexByName(step.AttachNames[i]);

                            if (index != -1)
                                ctrl.ListaAtasamente[index].Attachment.ForeColor = Color.Black;
                        }
                        break;
                    case "BlockOverwrite":
                        ctrl.Lista.VisualElements[step.Swit.Item1].ChangeValue(step.Swit.Item2);
                        break;
                    case "CBlockOverwrite":
                        ctrl.ExtraBlocks[0].VisualElements[step.Swit.Item1].ChangeValue(step.Swit.Item2);
                        break;
                    case "ABlockOverwrite":
                        ctrl.ExtraBlocks[1].VisualElements[step.Swit.Item1].ChangeValue(step.Swit.Item2);
                        break;
                    case "THighlight":
                        for (int i = 0; i < variableDataGridView.Rows.Count; i++)
                            if (step.HighlightedTableIndexes.Contains(i))
                                variableDataGridView.Rows[i].Selected = true;
                        break;
                    case "THClear":
                        variableDataGridView.ClearSelection();
                        break;
                    case "InitCountVisuals":
                        if (step.ExtraCountValues != null && step.ExtraAuxiliaryValues != null)
                            ctrl.generateExtraBlocks(step.ExtraCountValues, step.ExtraAuxiliaryValues);
                        else
                            ctrl.generateExtraBlocks();

                        for (int i = 0; i < ctrl.Lista.VisualElements.Count; i++)
                        {
                            panelAnimation.Controls.Add(ctrl.ExtraBlocks[0].VisualElements[i].Block);
                            panelAnimation.Controls.Add(ctrl.ExtraBlocks[1].VisualElements[i].Block);
                            ctrl.ExtraBlocks[0].VisualElements[i].Value.BringToFront();
                            ctrl.ExtraBlocks[1].VisualElements[i].Value.BringToFront();

                            ctrl.ExtraBlocks[0].VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.ExtraBlocks[0].VisualElements.Count + 12 * (ctrl.ExtraBlocks[0].VisualElements.Count - 1))) / 2 + i * (ctrl.ExtraBlocks[0].VisualElements[i].Block.Width + 12), 225 + ctrl.ExtraBlocks[0].VisualElements[i].Location.Y);
                            ctrl.ExtraBlocks[1].VisualElements[i].Location = new Point((panelAnimation.Width - (40 * ctrl.ExtraBlocks[1].VisualElements.Count + 12 * (ctrl.ExtraBlocks[1].VisualElements.Count - 1))) / 2 + i * (ctrl.ExtraBlocks[1].VisualElements[i].Block.Width + 12), 275 + ctrl.ExtraBlocks[1].VisualElements[i].Location.Y);

                            AttachmentElement EA = new AttachmentElement(i.ToString());
                            ctrl.ExtraAtasamente.add(EA);
                            panelAnimation.Controls.Add(EA.Attachment);
                            EA.setLocation(ctrl.ExtraBlocks[1].VisualElements[i].Block.Location, 1);
                        }

                        AttachmentElement AE = new AttachmentElement("C");
                        ctrl.ExtraAtasamente.add(AE);
                        panelAnimation.Controls.Add(AE.Attachment);
                        AE.setAsArrayName(ctrl.ExtraBlocks[0].VisualElements[0].Block.Location);
                        AE = new AttachmentElement("A");
                        ctrl.ExtraAtasamente.add(AE);
                        panelAnimation.Controls.Add(AE.Attachment);
                        AE.setAsArrayName(ctrl.ExtraBlocks[1].VisualElements[0].Block.Location);

                        break;
                    case "!InitCountVisuals":
                        for(int i =0;i<ctrl.ExtraBlocks[0].VisualElements.Count;i++)
                        {
                            panelAnimation.Controls.Remove(ctrl.ExtraBlocks[0].VisualElements[i].Block);
                            panelAnimation.Controls.Remove(ctrl.ExtraBlocks[1].VisualElements[i].Block);
                        }

                        for (int i = 0; i < ctrl.ExtraAtasamente.Lista.Count; i++)
                            panelAnimation.Controls.Remove(ctrl.ExtraAtasamente.Lista[i].Attachment);

                        ctrl.destroyExtraBlocks();

                        break;
                    case "ECHighlight":
                        for (int i = 0; i < ctrl.ExtraBlocks[0].VisualElements.Count; i++)
                            if (step.HighlightedCountExtraC.Contains(i))
                                ctrl.ExtraBlocks[0].VisualElements[i].Block.BackColor = Color.Red;
                            else
                                ctrl.ExtraBlocks[0].VisualElements[i].Block.BackColor = Color.Orange;
                        break;
                    case "EAHighlight":
                        for (int i = 0; i < ctrl.ExtraBlocks[0].VisualElements.Count; i++)
                            if (step.HighlightedCountExtraA.Contains(i))
                                ctrl.ExtraBlocks[1].VisualElements[i].Block.BackColor = Color.Red;
                            else
                                ctrl.ExtraBlocks[1].VisualElements[i].Block.BackColor = Color.Orange;
                        break;
                }
        }

        public void Highlight(List<int> listOfIndexes)
        {
            rchCode.Clear();

            string alg;

            switch(SortIndex)
            {
                case 0: alg = "BubbleSort"; break;
                case 1: alg = "InsertionSort"; break;
                case 2: alg = "SelectionSort"; break;
                case 3: alg = "CountSort"; break;
                case 4: alg = "MergeSort"; break;
                default: alg = "QuickSort"; break;
            }

            System.IO.StreamReader file =new System.IO.StreamReader(@".\Algorithms\"+alg+".txt");
            string line;
            int index = 1;

            while ((line = file.ReadLine()) != null)
            {
                if(listOfIndexes.Contains(index))
                {
                    rchCode.SelectionColor = Color.Black;
                    rchCode.SelectionBackColor = Color.Gold;
                    rchCode.AppendText(line + "\n");
                }
                else
                {
                    rchCode.SelectionColor = Color.White;
                    rchCode.SelectionBackColor = rchCode.BackColor;
                    rchCode.AppendText(line + "\n");
                }
                rchCode.Refresh();
                index++;
            }

            file.Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Step--;
            CurrentStep = "prev";
            executeStep();
            btnNext.Enabled = true;
            if (Step == 1)
                btnPrevious.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Step++;
            CurrentStep = "next";
            executeStep();
            btnPrevious.Enabled = true;
            if (Step == ctrl.Steps.Count)
                btnNext.Enabled = false;
        }

        private void Reset()
        {
            panelAnimation.Controls.Clear();
            panelAnimation.Controls.Add(labelTitle);
            labelTitle.Text = "";
            variableDataGridView.Rows.Clear();
            rchCode.Clear();
            rchExplanation.Clear();
            btnPrevious.Enabled = false;
            btnNext.Enabled = true;

            ctrl.newList(txtList.Text);
        }

        private void btnGenerateRandomList_Click(object sender, EventArgs e)
        {
            txtList.Clear();
            btnSave.Enabled = false;
            btnNewList.Enabled = true;
            txtList.Enabled = false;
            btnModify.Enabled = true;

            List<int> numbers = ctrl.generateRandomList();

            for (int i = 0; i < numbers.Count; i++)
                if (i < numbers.Count - 1)
                    txtList.Text += numbers[i] + " ";
                else
                    txtList.Text += numbers[i];

            enableAlgButtons();
        }

        private void enableAlgButtons()
        {
            btnBubble.Enabled = true;
            btnInsertion.Enabled = true;
            btnCount.Enabled = true;
            btnSelection.Enabled = true;
        }

        private void disableAlgButtons()
        {
            btnBubble.Enabled = false;
            btnInsertion.Enabled = false;
            btnCount.Enabled = false;
            btnSelection.Enabled = false;
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            disableAlgButtons();
            txtList.Clear();
            txtList.Enabled = true;
            btnSave.Enabled = true;
            btnModify.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctrl.Valid(txtList.Text))
            {
                txtList.Enabled = false;
                btnSave.Enabled = false;
                btnModify.Enabled = true;
                enableAlgButtons();
            }
            else
                MessageBox.Show("Sir invalid!\n\nUn sir valid contine:\n-minim 2 si maxim 10 elemente intregi din intervalul [0, 99]\n-elementele vor fi separate de un spatiu ' '\n\nExemplu:\n5 2 4 3 1\nsau\n23 15 19 24 59 37", "Atentionare!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            btnModify.Enabled = false;
            txtList.Enabled = true;
            btnSave.Enabled = true;
            disableAlgButtons();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutGUI gui = new AboutGUI();
            gui.ShowDialog();
        }
    }
}