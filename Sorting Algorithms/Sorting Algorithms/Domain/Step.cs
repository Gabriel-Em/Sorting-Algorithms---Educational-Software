using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Step
    {
        public List<int> Highlight { get; set; }
        public string Message { get; set; }
        public string Command { get; set; }
        public List<string> AttachNames { get; set; }
        public List<int> AttachTo { get; set; }
        public List<int> Rows { get; set; }
        public List<string> VariableNames { get; set; }
        public List<string> Values { get; set; }
        public List<int> VariableIndexes { get; set; }
        public List<int> HighlightedBlockIndexes { get; set; }
        public List<int> HighlightedLabelIndexes { get; set; }
        public List<int> HighlightedTableIndexes { get; set; }
        public List<int> HighlightedCountExtraC { get; set; }
        public List<int> HighlightedCountExtraA { get; set; }
        public int Delimiter;
        public bool UseDelimForUpdateInit;
        public List<int> ExtraCountValues { get; set; }
        public List<int> ExtraAuxiliaryValues { get; set; }
        public Tuple<int,int> Swit { get; set; }

        public Step()
        {
            Highlight = new List<int>();
            Message = "";
            Command = "";
            AttachNames = null;
            AttachTo = null;
            Rows = null;
            VariableNames = null;
            Values = null;
            VariableIndexes = null;
            HighlightedBlockIndexes = null;
            HighlightedLabelIndexes = null;
            HighlightedTableIndexes = null;
            HighlightedCountExtraC = null;
            HighlightedCountExtraA = null;
            ExtraCountValues = null;
            ExtraAuxiliaryValues = null;
            Swit = new Tuple<int, int>(-1, -1);
            Delimiter = -1;
            UseDelimForUpdateInit = false;

        }

        public Step Clone()
        {
            Step newStep = new Step();
            newStep.Highlight = Highlight;
            newStep.Message = Message;
            newStep.Command = Command;

            if (AttachNames != null)
                newStep.AttachNames = AttachNames.ToList<string>();
            if (AttachTo != null)
                newStep.AttachTo = AttachTo.ToList<int>();
            if (Rows != null)
                newStep.Rows = Rows.ToList<int>();
            if (VariableNames != null)
                newStep.VariableNames = VariableNames.ToList<string>();
            if (VariableIndexes != null)
                newStep.VariableIndexes = VariableIndexes.ToList<int>();
            if (Values != null)
                newStep.Values = Values.ToList<string>();
            if (HighlightedBlockIndexes != null)
                newStep.HighlightedBlockIndexes = HighlightedBlockIndexes.ToList<int>();
            if (HighlightedLabelIndexes != null)
                newStep.HighlightedLabelIndexes = HighlightedLabelIndexes.ToList<int>();
            if (HighlightedTableIndexes != null)
                newStep.HighlightedTableIndexes = HighlightedTableIndexes.ToList<int>();
            if (HighlightedCountExtraC != null)
                newStep.HighlightedCountExtraC = HighlightedCountExtraC.ToList<int>();
            if (HighlightedCountExtraA != null)
                newStep.HighlightedCountExtraA = HighlightedCountExtraA.ToList<int>();
            if (ExtraCountValues != null)
                newStep.ExtraCountValues = ExtraCountValues.ToList<int>();
            if (ExtraAuxiliaryValues != null)
                newStep.ExtraAuxiliaryValues = ExtraAuxiliaryValues.ToList<int>();

            newStep.Swit = Swit;
            newStep.Delimiter = Delimiter;
            newStep.UseDelimForUpdateInit = UseDelimForUpdateInit;
            return newStep;
        }
    }
}
