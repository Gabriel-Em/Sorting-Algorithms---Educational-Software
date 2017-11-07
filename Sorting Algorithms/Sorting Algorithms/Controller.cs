using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace Sorting_Algorithms
{
    class Controller
    {
        public ListaBlocuri Lista;
        public ListaAtasamente ListaAtasamente;
        public GUI Gui;
        public List<CStep> Steps;
        public List<ListaBlocuri> ExtraBlocks;
        public ListaAtasamente ExtraAtasamente;

        public Controller(GUI gui)
        {
            Gui = gui;
            Steps = new List<CStep>();
        }

        public void generateExtraBlocks()
        {
            ExtraBlocks = new List<ListaBlocuri>();
            ExtraAtasamente = new ListaAtasamente();

            List<int> defaultVals = new List<int>();

            for (int i = 0; i < Lista.IntegerElements.Count; i++)
                defaultVals.Add(0);

            ListaBlocuri count = new ListaBlocuri(defaultVals.ToList<int>());

            for (int i = 0; i < defaultVals.Count; i++)
                defaultVals[i] = -1;

            ListaBlocuri aux = new ListaBlocuri(defaultVals.ToList<int>());
            ExtraBlocks.Add(count);
            ExtraBlocks.Add(aux);
        }

        public void generateExtraBlocks(List<int> defValuesC,List<int> defValuesA)
        {
            ExtraBlocks = new List<ListaBlocuri>();
            ExtraAtasamente = new ListaAtasamente();
            ListaBlocuri count = new ListaBlocuri(defValuesC.ToList<int>());
            ListaBlocuri aux = new ListaBlocuri(defValuesA.ToList<int>());
            ExtraBlocks.Add(count);
            ExtraBlocks.Add(aux);
        }

        public void destroyExtraBlocks()
        {
            for(int i =0;i<ExtraBlocks[0].VisualElements.Count;i++)
            {
                ExtraBlocks[0].VisualElements[i].Dispose();
                ExtraBlocks[1].VisualElements[i].Dispose();
            }

            for (int i = 0; i < ExtraAtasamente.Lista.Count;i++)
                ExtraAtasamente[i].Dispose();

            ExtraBlocks = null;
            ExtraAtasamente = null;
        }

        public void newList(string lista)
        {
            Lista = new ListaBlocuri(listFromString(lista));
            ListaAtasamente = new ListaAtasamente();
            Steps = new List<CStep>();
        }

        public void Reset()
        {
            Lista = null;
            ListaAtasamente = null;
            Steps = new List<CStep>();
        }

        private List<int> listFromString(string list)
        {
            string[] sList = list.Split(' ');
            List<int> iList = new List<int>();

            foreach(string s in sList)
                iList.Add(Convert.ToInt32(s));

            return iList;
        }

        public bool Valid(string list)
        {
            string[] elemente = list.Split(' ');

            if (elemente.Length < 2 || elemente.Length > 10)
                return false;

            foreach(string split in elemente)
            {
                int value;
                if (!int.TryParse(split, out value))
                    return false;
                if (int.Parse(split) < 0 || int.Parse(split) > 99)
                    return false;
            }
            return true;
        }

        public List<int> generateRandomList()
        {
            List<int> randomList = new List<int>();
            Random r = new Random();
            int len, number;

            len = r.Next(2, 11);

            do
            {
                number = r.Next(1, 99);

                while (randomList.Contains(number))
                    number = r.Next(1, 99);

                randomList.Add(number);

            } while (randomList.Count < len);

            return randomList;
        }

        public void addAE(AttachmentElement AE)
        {
            ListaAtasamente.add(AE);
        }
        /* ------------------------------------------------------------------------------
         * ------------------------------- BUBBLE SORT ----------------------------------
         * ------------------------------------------------------------------------------
         */

        public void BubbleSort()
        {
            ///////////////////// Antet algoritm ////////////////////////

            CStep cstep = new CStep();
            Step step = new Step();
            step.Highlight = new List<int>() { 1 };
            step.Message = "Primim ca parametru un sir de elmente si lungimea sa.";
            step.Command = "Init|THClear";
            step.VariableNames = new List<string>() { "lenSir" };
            step.Values = new List<string>() { Lista.IntegerElements.Count().ToString() };
            step.VariableIndexes = new List<int>() { 0 };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|THClear";
            step.VariableIndexes = new List<int> { 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            //////////////////// bool ok; /////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 3 };
            step.Message = "Declaram o variabila 'ok' pe care o vom folosi ca sa ne dam seama daca am efectuat operatii pe sir in urma ultimei parcurgeri. Daca nu am efectuat nicio operatie inseamna ca sirul era deja sortat.";
            cstep.PrevStep = step;
            step.Command = "THClear";
            step = step.Clone();
            step.VariableNames = new List<string>() { "ok" };
            step.Values = new List<string>() { "-" };
            step.VariableIndexes = new List<int> { 1 };
            step.Command = "Init|THClear";
            cstep.NextStep = step;
            Steps.Add(cstep);

            bool ok;

            /////////////////// do while ////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 4, 5, 16 };
            step.Message = "Efectuam operatii pe sir in timp ce il parcurgem (odata sau de mai mult ori) pana cand in urma unei parcurgeri a sirului acesta este sortat corespunzator.";
            cstep.NextStep = step;
            step.Command = "THClear";
            step = step.Clone();
            step.Command = "Update|THClear";
            step.Values = new List<string>() { "-" };
            step.VariableIndexes = new List<int>() { 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            do
            {
                /////////////////////// ok = true ///////////////////////

                ok = true;
                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 6 };
                step.Message = "Presupunem ca sirul este deja sortat, si ca sa facem asta il initializam pe 'ok' cu 'true'. (presupunem ca sirul e ok)";
                step.Command = "Update|THighlight";
                step.VariableIndexes = new List<int> { 1 };
                step.Values = new List<string> { ok.ToString() };
                step.HighlightedTableIndexes = new List<int>() { 1 };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Detach|!Init|THighlight";
                step.AttachNames = new List<string>() { "i" };
                step.VariableIndexes = new List<int>() { 2 };
                cstep.PrevStep = step;
                Steps.Add(cstep);

                /////////////////// intram in for ///////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 7 };
                step.Message = "Incepem parcurgerea sirului. Pentru asta folosim un index 'i' care merge de la '0' pana la penultimul element 'lenSir - 2' deoarece la fiecare pas vom selecta elementele " +
                    "de pe pozitiile 'i' si 'i+1' pentru comparare si acest lucru nu ar fi posibil in cazul in care 'i' ar fi ultimul element din sir.";
                step.Command = "Highlight|THClear";
                step.HighlightedBlockIndexes = new List<int>();
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "Attach|Init|THClear";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { 0 };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 2 };
                step.VariableNames = new List<string>() { "i" };
                step.Values = new List<string>() { "0" };
                cstep.NextStep = step;
                Steps.Add(cstep);

                for (int i = 0; i < Lista.IntegerElements.Count - 1; i++)
                {
                    ///////////////// if (sir[i] > sir[i+1]) //////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 8 };
                    step.Message = "Comparam elementul de pe pozitia 'i' cu cel de pe pozitia 'i+1'. Daca acestea nu respecta criteriul de comparare (sir crescator in acest caz), atunci efectuam " +
                        "operatii cu aceste elemente, altfel continuam parcurgerea listei.\nIn acest moment:\nsir[i] = " + Lista.IntegerElements[i] + "\nsir[i+1] = " + Lista.IntegerElements[i + 1];
                    step.Command = "Highlight|THClear";
                    step.HighlightedBlockIndexes = new List<int>() { i, i + 1 };
                    cstep.NextStep = step;

                    if (Lista.IntegerElements[i] <= Lista.IntegerElements[i + 1])
                    {
                        step = step.Clone();
                        step.Command = "Highlight|Attach|Update|THClear";
                        step.AttachNames = new List<string>() { "i" };
                        step.AttachTo = new List<int>() { i };
                        step.Rows = new List<int>() { 2 };
                        step.Values = new List<string> { i.ToString() };
                        step.VariableIndexes = new List<int> { 2 };
                    }
                    else
                    {
                        step = step.Clone();
                        step.Command = "Highligt|Swap|THClear";
                        step.Swit = new Tuple<int, int>(i, i + 1);
                    }

                    cstep.PrevStep = step;
                    Steps.Add(cstep);


                    if (Lista.IntegerElements[i] > Lista.IntegerElements[i + 1])
                    {
                        //////////////////// interschimbare ////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 10, 11, 12 };
                        step.Message = "Interschimbam cele doua elemente.";
                        step.Command = "Swap|THCLear";
                        step.Swit = new Tuple<int, int>(i, i + 1);
                        cstep.NextStep = step;
                        step = step.Clone();
                        step.Command = "Update|Highlight|THClear";
                        step.HighlightedBlockIndexes = new List<int>() { i, i + 1 };
                        step.Values = new List<string>() { ok.ToString() };
                        step.VariableIndexes = new List<int>() { 1 };
                        cstep.PrevStep = step;
                        Steps.Add(cstep);

                        int aux = Lista.IntegerElements[i];
                        Lista.IntegerElements[i] = Lista.IntegerElements[i + 1];
                        Lista.IntegerElements[i + 1] = aux;

                        ///////////////////// ok = false ////////////////////////

                        ok = false;

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 14 };
                        step.Message = "Setam 'ok' la 'false' ca sa anuntam ca am avut de efectuat operatii pe sir ceea ce inseamna ca acesta nu a fost sortat in timpul parcurgerii pe care o efectuam acum.";
                        step.Command = "Update|THighlight|Highlight";
                        step.VariableIndexes = new List<int>() { 1 };
                        step.HighlightedTableIndexes = new List<int>() { 1 };
                        step.Values = new List<string>() { ok.ToString()};
                        step.HighlightedBlockIndexes = new List<int>();
                        cstep.NextStep = step;
                        step = step.Clone();
                        step.Command = "Attach|Update|THighlight";
                        step.AttachNames = new List<string>() { "i" };
                        step.AttachTo = new List<int>() { i };
                        step.Rows = new List<int>() { 2 };
                        step.VariableIndexes = new List<int>() { 2 };
                        step.Values = new List<string>() { i.ToString() };
                        cstep.PrevStep = step;
                        Steps.Add(cstep);

                        /////////////////////// i++ in for ////////////////////////
                    }

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 7 };
                    step.Message = "Incrementam 'i'-ul.\ni = " + (i+1).ToString() + "\nlenSir - 1 = " + (Lista.IntegerElements.Count - 1).ToString() + "\n";

                    if (i + 1 < Lista.IntegerElements.Count - 1)
                        step.Message += "Exista elementele sir[i] si sir[i+1], incepem o noua iteratie.";
                    else
                        step.Message += "sir[i] este ultimul element al sirului si nu exista un sir[i+1] deci finalizam parcurgerea si iesim din for.";

                    step.Command = "Attach|Update|Highlight|THClear";
                    step.AttachNames = new List<string>() { "i" };
                    step.AttachTo = new List<int>() { i + 1 };
                    step.Rows = new List<int>() { 2 };
                    step.VariableIndexes = new List<int>() { 2 };
                    step.Values = new List<string>() { (i + 1).ToString() };
                    step.HighlightedBlockIndexes = new List<int>();
                    cstep.NextStep = step;
                    if (i + 1 >= Lista.IntegerElements.Count - 1)
                    {
                        step = step.Clone();
                        step.Command = "Attach|Init|Highlight|THClear";
                        step.VariableNames = new List<string>() { "i" };
                    }
                    cstep.PrevStep = step;
                    Steps.Add(cstep);

                    //////////////////////// while(!ok) ///////////////////////
                }
                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 16 };
                step.Command = "Detach|!Init|THighlight";
                step.VariableIndexes = new List<int>() { 2 };
                step.AttachNames = new List<string>() { "i" };

                if (ok)
                    step.Message = "ok = true, deci nu am efectuat nicio operatie pe sir ceea ce inseamna ca toate elementele din sir se afla pe pozitiile lor corecte (sirul e sortat).";
                else
                    step.Message = "ok = false, deci am efectuat operatii pe sir si exista posibilitatea ca acesta sa nu fie sortat.";

                step.HighlightedTableIndexes = new List<int>() { 1 };
                cstep.NextStep = step;
                step = step.Clone();
                if (ok)
                {
                    step.Command = "Init|THighlight";
                    step.VariableNames = new List<string>() { "ok" };
                }
                else
                    step.Command = "Update|THighlight";

                step.VariableIndexes = new List<int> { 1 };
                step.Values = new List<string>() { ok.ToString() };
                cstep.PrevStep = step;
                Steps.Add(cstep);
                
            } while (!ok);

            //////////////////////// sfarsit algoritm /////////////////////////

            step = new Step();
            step.Highlight = new List<int>() { 17 };
            step.Message = "Sfarsit! Sirul este sortat.";
            step.Command = "!Init|THClear";
            step.VariableIndexes = new List<int>() { 1 };
            Steps.Add(new CStep(step, null));
        }

        /* ------------------------------------------------------------------------------
         * ----------------------------- INSERTION SORT ---------------------------------
         * ------------------------------------------------------------------------------
         */

        internal void InsertionSort()
        {
            ///////////////////// Antet algoritm ////////////////////////

            CStep cstep = new CStep();
            Step step = new Step();
            step.Highlight = new List<int>() { 1 };
            step.Message = "Primim ca parametru un sir de elmente si lungimea sa.";
            step.Command = "Init|THClear";
            step.VariableNames = new List<string>() { "lenSir" };
            step.Values = new List<string>() { Lista.IntegerElements.Count().ToString() };
            step.VariableIndexes = new List<int>() { 0 };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|THClear";
            step.VariableIndexes = new List<int> { 2, 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            //////////////////// int aux, poz; /////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 3 };
            step.Message = "Declaram doua variabile:\n-'aux' pe care o vom folosi ca sa memoram elementul de pe pozitia i in timp ce parcurgem sirul\n-'poz' - o alta variabila auxiliara pe " +
                "care o vom folosi pentru a putea selecta elemente din stanga elementului de pe pozitia 'i'";
            step.Command = "Detach|!Init|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.VariableIndexes = new List<int>() { 3 };
            cstep.PrevStep = step;
            step = step.Clone();
            step.VariableNames = new List<string>() { "aux", "poz" };
            step.Values = new List<string>() { "-", "-" };
            step.VariableIndexes = new List<int> { 1, 2 };
            step.Command = "Init|THClear";
            cstep.NextStep = step;
            Steps.Add(cstep);

            int aux, poz=-1;

            /////////////////// intram in for ///////////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 5 };
            step.Message = "Incepem parcurgerea sirului. Pentru asta folosim un index 'i' care incepe de la a doua pozitie pana la ultima pozitie din sir deoarece la fiecare pas vom salva " +
                "elementul de pe pozitia 'i' in variabila 'aux' si vom muta toate elementele din stanga lui care sunt mai mari (in cazul asta) decat acest element cu o pozitie spre dreapta " +
                "(daca 'i' ar incepe de la prima pozitie, atunci nu am avea elemente in stanga lui). La intalnirea unui element mai mic decat cel pe care l-am salvat in 'aux' il vom insera pe "+
                "'aux' in fata acelui element (toate celelalte elemente mai mari decat 'aux' au fost mutate cu o pozitie mai in dreapta, astfel incat am facut loc pentru 'aux' in fata primului "+
                "element mai mic decat 'aux'). Daca toate elementele sunt mai mari decat 'aux', atunci nu vom intalni un element mai mic decat caz in care dupa mutarea tuturor elementelor "+
                "mai mari cu o pozitie spre stanga, 'aux' va fi inserat pe prima pozitie din sir.";
            step.Command = "Update|THClear|Highlight";
            step.HighlightedBlockIndexes = new List<int>();
            step.VariableIndexes = new List<int>() { 1 };
            step.Values = new List<string>() { "-" };
            cstep.PrevStep = step;
            step = step.Clone();
            step.Command = "Attach|Init|THCLear";
            step.AttachNames = new List<string>() { "i" };
            step.AttachTo = new List<int>() { 1 };
            step.Rows = new List<int>() { 2 };
            step.VariableIndexes = new List<int>() { 3 };
            step.VariableNames = new List<string>() { "i" };
            step.Values = new List<string>() { "1" };
            cstep.NextStep = step;
            Steps.Add(cstep);

            for (int i = 1; i < Lista.IntegerElements.Count; i++)
            {
                ////////////////////// init aux ///////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 7 };
                step.Message = "Salvam elementul de pe pozitia 'i' in 'aux' pentru ca in momentul in care mutam elmentele mai mari decat acesta din stanga lui cu o pozitie spre dreapta, valoarea elementului de pe pozitia 'i' se va pierde.";
                step.Command = "Update|THighlight|Highlight";
                step.HighlightedBlockIndexes = new List<int>() { i };
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.AttachNames = new List<string>() { "poz" };
                if (poz == -1)
                {
                    step.Command += "|Detach";
                    step.Values = new List<string>() { "-" };
                }
                else
                {
                    step.Command += "|Attach";
                    step.AttachTo = new List<int>() { poz };
                    step.Rows = new List<int>() { 3 };
                    step.Values = new List<string>() { poz.ToString() };
                }
                step.VariableIndexes = new List<int>() { 2 };
                
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "Update|THighlight|Highlight";
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { Lista.IntegerElements[i].ToString() };
                cstep.NextStep = step;
                Steps.Add(cstep);

                aux = Lista.IntegerElements[i];

                ////////////////////// init poz ///////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 8 };
                step.Message = "Initializam variabila 'poz' cu 'i' si o folosim pentru a ne referi la elementele din stanga elementului de pe pozitia 'i'. ";
                step.Command = "Highlight|!AEHighlight|THClear|IHighlight";
                step.HighlightedBlockIndexes = new List<int>();
                step.HighlightedLabelIndexes = new List<int>();
                step.AttachNames = new List<string>() { "poz" };
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "Attach|Update|THClear|Highlight";
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 3 };
                step.VariableIndexes = new List<int>() { 2 };
                step.Values = new List<string>() { i.ToString() };
                cstep.NextStep = step;
                Steps.Add(cstep);

                poz = i;

                /////////////////////////// intram in while ////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 10 };
                step.Message = "Pentru ca mai sus am initializat 'poz' la 'i' si 'i' nu devine niciodata 0, 'poz' va fi intotdeauna mai mare decat '0' la prima intrare in while din timpul unei iteratii a forului. A doua conditie in schimb poate sa fie adevarata sau nu. Comparam elementul de pe pozitia 'poz-1' cu 'aux'.\nIn acest moment:\nsir[poz-1] = " + Lista.IntegerElements[poz - 1] + "\naux = " + aux;
                step.Command = "AEHighlight|Highlight|IHighlight|THighlight";
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.AttachNames = new List<string>() { "poz" };
                step.HighlightedBlockIndexes = new List<int>() { poz - 1 };
                step.HighlightedLabelIndexes = new List<int>() { 0 };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "AEHighlight|Highlight|IHighlight|BlockOverwrite|THighlight";
                step.Swit = new Tuple<int, int>(poz, Lista.IntegerElements[poz]);
                cstep.PrevStep = step;
                Steps.Add(cstep);

                while (poz > 0 && Lista.IntegerElements[poz - 1] > aux)
                {
                    ////////////////////////////////// sir[poz] = sir[poz-1] ///////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 12 };
                    step.Message = "Deoarece elementul de pe pozitia 'poz -1' e mai mare decat elementul pe care l-am salvat in 'aux', mutam acest element cu o pozitie spre dreapta.";
                    step.Command = "!AEHighlight|Highlight|BlockOverwrite|IHighlight|THClear";
                    step.HighlightedLabelIndexes = new List<int>();
                    step.AttachNames = new List<string>() { "poz" };
                    step.HighlightedBlockIndexes = new List<int>() { poz, poz - 1 };
                    step.Swit = new Tuple<int, int>(poz, Lista.IntegerElements[poz-1]);
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Update|Highlight|Attach|THClear";
                    step.AttachTo = new List<int>() { poz };
                    step.Rows = new List<int>() { 3 };
                    step.Values = new List<string>() { poz.ToString() };
                    step.VariableIndexes = new List<int>() { 2 };
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                    Lista.IntegerElements[poz] = Lista.IntegerElements[poz - 1];

                    /////////////////////////////// poz-- ///////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 13 };
                    step.Message = "Apoi mutam 'poz' cu o pozitie spre stanga pentru a efectua o noua verificare.";
                    step.Command = "Attach|Update|Highlight|THClear";
                    step.AttachNames = new List<string>() { "poz" };
                    step.AttachTo = new List<int>() { poz - 1 };
                    step.Rows = new List<int>() { 3 };
                    step.HighlightedBlockIndexes = new List<int>();
                    step.VariableIndexes = new List<int>() { 2 };
                    step.Values = new List<string>() { (poz-1).ToString() };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "!AEHighlight|IHighlight|THClear";

                    if (poz != 0)
                        step.Command += "|Highlight";

                    step.HighlightedLabelIndexes = new List<int>();
                    cstep.PrevStep = step;

                    Steps.Add(cstep);

                    poz--;

                    /////////////////////////////// conditie while //////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 10 };
                    ;

                    if (poz == 0)
                    {
                        step.Message = "'poz' a ajuns pe pozitia 0 ceea ce inseamna ca toate elementele din stanga celui salvat in 'aux' au fost mai mari decat acesta.";
                        step.Command = "AEHighlight|IHighlight|THClear";
                    }
                    else
                    {
                        step.Message = "Pentru ca 'poz' n-a ajuns inca pe pozitia 0 comparam elementul de pe pozitia 'poz-1' cu 'aux'.\nIn acest moment:\nsir[poz-1] = " + Lista.IntegerElements[poz - 1] + "\naux = " + aux;
                        if (Lista.IntegerElements[poz - 1] > aux)
                            step.Message += "\nDeoarece sir[poz-1] e mai mare decat aux";
                        step.Command = "AEHighlight|Highlight|IHighlight|THighlight";
                        step.HighlightedTableIndexes = new List<int>() { 1 };
                        step.HighlightedBlockIndexes = new List<int>() { poz - 1 };
                    }

                    step.AttachNames = new List<string>() { "poz" };
                    step.HighlightedLabelIndexes = new List<int>() { 0 };
                    cstep.NextStep = step;
                    step = step.Clone();
                    if (poz == 0)
                    {
                        step.Command = "AEHighlight|IHighlight|BlockOverwrite|THClear|Highlight";
                        step.HighlightedBlockIndexes = new List<int>();
                    }
                    else
                        step.Command = "AEHighlight|Highlight|IHighlight|BlockOverwrite|THighlight";
                    step.Swit = new Tuple<int, int>(poz, Lista.IntegerElements[poz]);
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                }

                /////////////////////////// sir[poz] = aux ///////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 16 };

                if (poz == 0)
                    step.Message = "Inseram elementul 'aux' pe pozitia 0.";
                else
                    step.Message = "Deoarece elementul de pe pozitia 'poz-1' a fost mai mic decat 'aux' il inseram pe 'aux' in dreapta acestui element (pe pozitia 'poz').";
                step.Command = "Attach|Update|Highlight|THighlight";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 3 };
                step.Values = new List<string>() { i.ToString() };
                step.HighlightedBlockIndexes = new List<int>() { poz };
                step.HighlightedTableIndexes = new List<int>() { 1 };
                cstep.PrevStep = step;
                step = step.Clone();
                step.Command = "!AEHighlight|Highlight|BlockOverwrite|IHighlight|THighlight";
                step.HighlightedTableIndexes = new List<int>() { 1 };
                step.HighlightedLabelIndexes = new List<int>();
                step.AttachNames = new List<string>() { "poz" };
                step.HighlightedBlockIndexes = new List<int>() { poz };
                step.Swit = new Tuple<int, int>(poz, aux);
                cstep.NextStep = step;
                Steps.Add(cstep);

                Lista.IntegerElements[poz] = aux;

                //////////////////////////// i++ in for //////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 5 };
                step.Message = "Incrementam 'i'-ul.\ni = " + (i + 1).ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\n";

                if (i + 1 < Lista.IntegerElements.Count)
                    step.Message += "Inca n-am ajuns la ultimul element, deci incepem o noua iteratie.";
                else
                    step.Message += "i-ul pointeaza in afara sirului deci finalizam parcurgerea si iesim din for.";

                step.Command = "Attach|Update|Highlight|THClear";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i + 1 };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 3 };
                step.Values = new List<string>() { (i + 1).ToString() };
                step.HighlightedBlockIndexes = new List<int>();
                cstep.NextStep = step;
                step = step.Clone();

                if (i+1 == Lista.IntegerElements.Count)
                {
                    step.Command = "Attach|Init|THClear";
                    step.AttachNames = new List<string>() { "i", "poz" };
                    step.AttachTo = new List<int>() { i + 1, poz };
                    step.Rows = new List<int>() { 2, 3 };
                    step.VariableNames = new List<string>() { "aux", "poz", "i" };
                    step.VariableIndexes = new List<int>() { 1, 2, 3 };
                    step.Values = new List<string>() { aux.ToString(), poz.ToString(), (i + 1).ToString() };
                }
                else
                {
                    step.Command = "Highlight|Update|THClear";
                    step.HighlightedBlockIndexes = new List<int>();
                    step.VariableIndexes = new List<int>() { 1 };
                    step.Values = new List<string>() { aux.ToString() };
                }
                cstep.PrevStep = step;
                Steps.Add(cstep);

                Lista.IntegerElements[poz] = aux;
            }

            //////////////////////// sfarsit algoritm /////////////////////////

            step = new Step();
            step.Highlight = new List<int>() { 18 };
            step.Message = "Sfarsit! Sirul este sortat.";
            step.Command = "!Init|Detach|THClear";
            step.VariableIndexes = new List<int>() { 3,2,1 };
            step.AttachNames = new List<string>() { "i", "poz" };
            Steps.Add(new CStep(step, null));
        }

        /* ------------------------------------------------------------------------------
         * ----------------------------- SELECTION SORT ---------------------------------
         * ------------------------------------------------------------------------------
         */

        internal void SeletionSort()
        {
            ///////////////////// Antet algoritm ////////////////////////

            CStep cstep = new CStep();
            Step step = new Step();
            step.Highlight = new List<int>() { 1 };
            step.Message = "Primim ca parametru un sir de elmente si lungimea sa.";
            step.Command = "Init|THClear";
            step.VariableNames = new List<string>() { "lenSir" };
            step.Values = new List<string>() { Lista.IntegerElements.Count().ToString() };
            step.VariableIndexes = new List<int>() { 0 };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|Detach|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.VariableIndexes = new List<int>() { 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            //////////////////////////////// int pozMin /////////////////////////////////////

            int pozMin;

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 3 };
            step.Message = "Declaram o variabila 'pozMin' in care vom salva pozitia elementului minim, la fiecare parcurgere a sirului, de la pozitia 'i' pana la ultimul element.";
            step.Command = "Init";
            step.VariableIndexes = new List<int>() { 1 };
            step.VariableNames = new List<string>() { "pozMin" };
            step.Values = new List<string>() { "-" };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|Detach|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.VariableIndexes = new List<int>() { 2 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            ////////////////////////////// for principal /////////////////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 5 };
            step.Message = "Incepem parcurgerea sirului. Pentru asta folosim un index 'i' care merge de la '0' pana la penultimul element 'lenSir - 2' deoarece la fiecare pas vom cauta elementul " +
                           "de valoare minima din sirul care incepe de la pozitia 'i' pana la ultimul element. (daca 'i' e ultimul element din sir, atunci el insusi e minimul si nu e necesara o parcurgere "
                           +"a sirului in cautarea lui)";
            step.Command = "Init|Attach|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.AttachTo = new List<int>() { 0 };
            step.Rows = new List<int>() { 2 };
            step.VariableIndexes = new List<int>() { 2 };
            step.VariableNames = new List<string>() { "i" };
            step.Values = new List<string>() { "0" };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "Update|Detach|THClear";
            step.AttachNames = new List<string>() { "pozMin" };
            step.VariableIndexes = new List<int>() { 1 };
            step.Values = new List<string>() { "-" };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            for (int i = 0; i < Lista.IntegerElements.Count - 1; i++)
            {

                //////////////////////////////////// pozMin = i ////////////////////////////////

                pozMin = i;

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 7 };
                step.Message = "Deoarece incepem cautarea minimului de la pozitia 'i', il initializam pe 'pozMin' cu 'i'.";
                step.Command = "Update|Attach|THClear";
                step.AttachNames = new List<string>() { "pozMin" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 3 };
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { i.ToString() };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "!Init|Detach|THClear";
                step.AttachNames = new List<string>() { "j" };
                step.VariableIndexes = new List<int>() { 3 };
                cstep.PrevStep = step;
                Steps.Add(cstep);

                ///////////////////////////////////// for j /////////////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 9 };
                step.Message = "Incepem cautarea elementului minim parcurgand sirul cu ajutorul unui index 'j' de la 'i+1' pana la final.";
                step.Command = "Init|Attach|THClear";
                step.AttachNames = new List<string>() { "j" };
                step.AttachTo = new List<int>() { i+1 };
                step.Rows = new List<int>() { -1 };
                step.VariableNames = new List<string>() { "j" };
                step.VariableIndexes = new List<int>() { 3 };
                step.Values = new List<string>() { (i+1).ToString() };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Highlight|THClear";
                step.HighlightedBlockIndexes = new List<int>();
                cstep.PrevStep = step;
                Steps.Add(cstep);

                for (int j = i + 1; j < Lista.IntegerElements.Count; j++)
                {

                    ////////////////////////////// sir[j] < sir[pozMin] ////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 10 };
                    step.Message = "Comparam elementele de pe pozitiile 'j' si 'pozMin'.\nsir[j] = " + Lista.IntegerElements[j] + "\nsir[pozMin] = " + Lista.IntegerElements[pozMin] +
                        "\nDaca elementul de pe pozitia 'j' e mai mic decat cel de pe pozitia 'pozMin' atunci salvam pozitia acestuia, altfel, continuam parcurgerea sirului.";
                    step.Command = "Highlight|THClear";
                    step.HighlightedBlockIndexes = new List<int>() { j, pozMin };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Highlight|Attach|Update|THCLear";

                    if (Lista.IntegerElements[j] >= Lista.IntegerElements[pozMin])
                    {
                        step.AttachNames = new List<string>() { "j" };
                        step.AttachTo = new List<int>() { j };
                        step.Rows = new List<int>() { -1 };
                        step.VariableIndexes = new List<int>() { 3 };
                        step.Values = new List<string>() { j.ToString() };
                    }
                    else
                    {
                        step.AttachNames = new List<string>() { "pozMin" };
                        step.AttachTo = new List<int>() { pozMin };
                        step.Rows = new List<int>() { 3 };
                        step.VariableIndexes = new List<int>() { 1 };
                        step.Values = new List<string>() { pozMin.ToString() };
                    }
                    cstep.PrevStep = step;
                    Steps.Add(cstep);

                    if (Lista.IntegerElements[j] < Lista.IntegerElements[pozMin])
                    {
                        ////////////////////////////// pozMin = j ////////////////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 11 };
                        step.Message = "Deoarece sir[j] a fost mai mic decat sir[pozMin] salvam pozitia lui sir[j] in pozMin.";
                        step.Command = "Highlight|Attach|Update|THClear";
                        step.HighlightedBlockIndexes = new List<int>();
                        step.AttachNames = new List<string>() { "pozMin" };
                        step.AttachTo = new List<int>() { j };
                        step.Rows = new List<int>() { 3 };
                        step.VariableIndexes = new List<int>() { 1 };
                        step.Values = new List<string>() { j.ToString() };
                        cstep.NextStep = step;
                        step = step.Clone();
                        step.Command = "Attach|Update|THClear";
                        step.AttachTo = new List<int>() { j };
                        step.AttachNames = new List<string>() { "j" };
                        step.VariableIndexes = new List<int>() { 3 };
                        step.Values = new List<string>() { j.ToString() };
                        step.Rows = new List<int>() { -1 };
                        cstep.PrevStep = step;
                        Steps.Add(cstep);

                        pozMin = j;
                    }

                    ////////////////////////////// j++ ////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 9 };
                    step.Message = "Incrementam 'j'-ul.\nj = " + (j + 1).ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\n";

                    if (j + 1 < Lista.IntegerElements.Count)
                        step.Message += "Inca n-am ajuns la ultimul element, deci continuam parcurgerea.";
                    else
                        step.Message += "j-ul pointeaza in afara sirului deci finalizam parcurgerea si iesim din for.";

                    step.Command = "Attach|Update|THClear";
                    step.AttachNames = new List<string>() { "j" };
                    step.AttachTo = new List<int>() { j + 1 };
                    step.Rows = new List<int>() { -1 };
                    step.VariableIndexes = new List<int>() { 3 };
                    step.Values = new List<string>() { (j + 1).ToString() };

                    if (Lista.IntegerElements[j] >= Lista.IntegerElements[pozMin])
                    {
                        step.Command += "|Highlight";
                        step.HighlightedBlockIndexes = new List<int>();
                    }

                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Highlight";
                    step.HighlightedBlockIndexes = new List<int>();

                    if (j + 1 >= Lista.IntegerElements.Count)
                    {
                        step.Command += "|Init|Attach|Swap|THClear";
                        step.VariableIndexes = new List<int>() { 3 };
                        step.VariableNames = new List<string>() { "j" };
                        step.Values = new List<string>() { (j + 1).ToString() };
                        step.AttachNames = new List<string>() { "j" };
                        step.AttachTo = new List<int>() { j + 1 };
                        step.Swit = new Tuple<int, int>(i, pozMin);
                        step.Rows = new List<int>() { -1 };
                    }

                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                }

                ///////////////////////////// interschimbare ////////////////////////////

                int aux = Lista.IntegerElements[pozMin];
                Lista.IntegerElements[pozMin] = Lista.IntegerElements[i];
                Lista.IntegerElements[i] = aux;

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 13, 14, 15 };
                step.Message = "Interschimbam elementele de pe pozitiile 'i' si 'pozMin'. In felul asta elementul minim se va afla la inceputul sirului cuprins in intervalul [i,lenSir-1].\n";
                step.Command = "Detach|!Init|Swap|Highlight|THClear";
                step.HighlightedBlockIndexes = new List<int>() { i, pozMin };
                step.AttachNames = new List<string>() { "j" };
                step.VariableIndexes = new List<int>() { 3 };
                step.Swit = new Tuple<int, int>(i, pozMin);
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Attach|Update|Highlight|THClear";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 2 };
                step.Values = new List<string>() { i.ToString() };
                cstep.PrevStep = step;
                Steps.Add(cstep);

                ///////////////////////////// i++ ////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 5 };
                step.Message = "Incrementam 'i'-ul.\ni = " + (i + 1).ToString() + "\nlenSir - 1 = " + (Lista.IntegerElements.Count-1).ToString() + "\n";

                if (i + 1 < Lista.IntegerElements.Count-1)
                    step.Message += "Inca n-am ajuns la ultimul element, deci incepem o noua iteratie.";
                else
                    step.Message += "'i'-ul pointeaza spre ultimul element din sir, care este deja minimul din intervalul [i,lenSir-1], asa ca finalizam parcurgerea si iesim din for.";

                step.Command = "Attach|Update|Highlight|THClear";
                step.HighlightedBlockIndexes = new List<int>();
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i + 1 };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 2 };
                step.Values = new List<string>() { (i + 1).ToString() };
                cstep.NextStep = step;
                step = step.Clone();

                if (i + 1 >= Lista.IntegerElements.Count()-1)
                {
                    step.Command = "Attach|Init|THClear";
                    step.AttachNames = new List<string>() { "i", "pozMin" };
                    step.AttachTo = new List<int>() { i + 1, pozMin };
                    step.Rows = new List<int>() { 2, 3 };
                    step.VariableIndexes = new List<int>() { 1, 2 };
                    step.VariableNames = new List<string>() { "pozMin", "i" };
                    step.Values = new List<string>() { pozMin.ToString(), (i + 1).ToString() };
                }
                else
                {
                    step.Command = "Attach|Update|THClear";
                    step.AttachNames = new List<string>() { "pozMin" };
                    step.AttachTo = new List<int>() { pozMin };
                    step.Rows = new List<int>() { 3 };
                    step.Values = new List<string>() { pozMin.ToString() };
                    step.VariableIndexes = new List<int>() { 1 };
                }

                cstep.PrevStep = step;
                Steps.Add(cstep);
            }

            //////////////////////// sfarsit algoritm /////////////////////////

            step = new Step();
            step.Highlight = new List<int>() { 17 };
            step.Message = "Sfarsit! Sirul este sortat.";
            step.Command = "!Init|Detach|THClear";
            step.VariableIndexes = new List<int>() { 2, 1 };
            step.AttachNames = new List<string>() { "i", "pozMin" };
            Steps.Add(new CStep(step, null));
        }

        /* ------------------------------------------------------------------------------
         * ------------------------------- COUNT SORT -----------------------------------
         * ------------------------------------------------------------------------------
         */

        public void CountSort()
        {
            ///////////////////// Antet algoritm ////////////////////////

            CStep cstep = new CStep();
            Step step = new Step();
            step.Highlight = new List<int>() { 1 };
            step.Message = "Primim ca parametru un sir de elmente si lungimea sa.";
            step.Command = "Init|THClear";
            step.VariableNames = new List<string>() { "lenSir" };
            step.Values = new List<string>() { Lista.IntegerElements.Count().ToString() };
            step.VariableIndexes = new List<int>() { 0 };
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!InitCountVisuals|THClear";
            cstep.PrevStep = step;
            Steps.Add(cstep);

            ///////////////////// Init count[] si sirAuxiliar[] ////////////////////////

            cstep = new CStep();
            step = new Step();
            step.Highlight = new List<int>() { 3 };
            step.Message = "Declaram 2 siruri auxiliare, 'count' si 'sirAuxiliar' pe care le vom folosi mai tarziu in algoritm. Initializam toate valorile din 'count' cu 0.\nIn sirul 'count' " +
                "o sa notam valori care vor reprezenta numarul valorilor din sirul original fata de care este mai mare sau egala valoarea de pe pozitia i.\n\nEx:\n\nDaca sir = [5,3,1,2,4]\n" +
                "                  0 1 2 3 4\n\nSirul 'count' ar fi [4,2,0,1,3], deoarece elementul de pe pozitia 0 este mai mare decat 4 elemente, cel de pe pozitia 1 este mai mare decat 2, etc." +
                "\n\nSirul 'sirAuxiliar' va fi folosit la finalul algoritmului atunci cand vom muta valorile din sirul original pe pozitia lor corecta (data de 'count') intr-un sir sortat, care " +
                "va fi 'sirAuxiliar'. Este necesar sa facem acest lucru deoarece nu putem muta elementele din sirul original direct in acelasi sir fara a evita suprascrierea.";
            step.Command = "InitCountVisuals|THClear";
            cstep.NextStep = step;
            step = step.Clone();
            step.Command = "!Init|Detach|THClear";
            step.AttachNames = new List<string>() { "i" };
            step.VariableIndexes = new List<int>() { 1 };
            cstep.PrevStep = step;
            Steps.Add(cstep);

            List<int> count = new List<int>(), sirAuxiliar = new List<int>();


            for (int i = 0; i < Lista.IntegerElements.Count; i++)
            {
                count.Add(0);
                sirAuxiliar.Add(0);
            }

            for (int i = 0; i < Lista.IntegerElements.Count - 1; i++)
            {
                ///////////////////////////////// for i ///////////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 5 };
                

                if (i == 0)
                {
                    step.Command = "Init|Attach|THClear";
                    step.VariableIndexes = new List<int>() { 1 };
                    step.VariableNames = new List<string>() { "i" };
                    step.AttachNames = new List<string>() { "i" };
                    step.Message = "Va trebui sa comparam fiecare element cu fiecare element asa ca pentru asta vom folosi un for cu un index 'i' care va merge de la 0 pana la penultimul " +
                    "element, for care va contine un al doilea for cu un index 'j' de la 'i+1' pana la ultimul element.";
                }
                else
                {
                    step.Command = "Update|!Init|Attach|Detach|THClear";
                    step.VariableIndexes = new List<int>() { 1, 2 };
                    step.AttachNames = new List<string>() { "i", "j" };
                    step.Delimiter = 1;
                    step.Message = "Incrementam 'i'-ul.\ni = " + i.ToString() + "\nlenSir - 1 = " + (Lista.IntegerElements.Count-1).ToString() + "\nCondita din for este adevarata, deci continuam parcurgerea.";
                }

                step.Values = new List<string>() { i.ToString() };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Detach|!Init|THCLear";
                step.AttachNames = new List<string>() { "j" };
                step.VariableIndexes = new List<int>() { 2 };
                step.Delimiter = -1;
                cstep.PrevStep = step;
                Steps.Add(cstep);

                for (int j = i + 1; j < Lista.IntegerElements.Count; j++)
                {
                    ///////////////////////////////// for j ///////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 6 };

                    if (j == i + 1)
                    {
                        step.Command = "Init";
                        step.VariableNames = new List<string>() { "j" };
                        step.Message = "Initializam 'j'-ul din al doilea for si incepem parcurgerea sirului de la 'i+1' pana la ultimul element.";
                    }
                    else
                    {
                        step.Command = "Update|ECHighlight";
                        step.HighlightedCountExtraC = new List<int>();
                        step.Message = "Incrementam 'j'-ul.\nj = " + j.ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este adevarata, deci continuam parcurgerea.";
                    }

                    step.Command += "|Attach|THClear";
                    step.VariableIndexes = new List<int>() { 2 };
                    step.Values = new List<string>() { j.ToString() };
                    step.AttachNames = new List<string>() { "j" };
                    step.AttachTo = new List<int>() { j };
                    step.Rows = new List<int>() { -1 };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Highlight|THCLear";
                    step.HighlightedBlockIndexes = new List<int>();
                    cstep.PrevStep = step;
                    Steps.Add(cstep);

                    ///////////////////////////////// if sir[i] < sir[j] ///////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 7 };
                    step.Message = "Comparam elementul de pe pozitia 'i' cu cel de pe pozitia 'j'.";
                    step.Command = "Highlight|THClear";
                    step.HighlightedBlockIndexes = new List<int>() { i, j };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Highlight|ECHighlight|CBlockOverwrite|THClear";
                    step.HighlightedCountExtraC = new List<int>();
                    
                    if (Lista.IntegerElements[i] < Lista.IntegerElements[j])
                    {
                        step.Swit = new Tuple<int, int>(j, count[j]);
                        cstep.PrevStep = step;
                        Steps.Add(cstep);

                        /////////////////////////////// count[j]++ ///////////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 8 };
                        step.Message = "Deoarece elementul de pe pozitia 'j' este mai mare decat cel de pe 'i', incremental valoarea asociata acestuia din 'count'.";
                        step.Command = "Highlight|ECHighlight|CBlockOverwrite|THClear";
                        step.HighlightedBlockIndexes = new List<int>();
                        step.HighlightedCountExtraC = new List<int>() { j };
                        step.Swit = new Tuple<int, int>(j, count[j] + 1);

                        count[j]++;
                    }
                    else
                    {
                        step.Swit = new Tuple<int, int>(i, count[i]);
                        cstep.PrevStep = step;
                        Steps.Add(cstep);

                        ///////////////////////////// count[i]++ ////////////////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 10 };
                        step.Message = "Deoarece elementul de pe pozitia 'j' NU este mai mare decat cel de pe 'i', incremental valoarea asociata lui 'i' din 'count'.";
                        step.HighlightedCountExtraC = new List<int>() { i };
                        step.Swit = new Tuple<int, int>(i, count[i] + 1);

                        count[i]++;
                    }

                    step.Command = "Highlight|ECHighlight|CBlockOverwrite|THClear";
                    step.HighlightedBlockIndexes = new List<int>();
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "ECHighlight|Attach|Update";
                    step.AttachNames = new List<string>() { "j" };
                    step.AttachTo = new List<int>() { j };
                    step.Rows = new List<int>() { -1 };
                    step.VariableIndexes = new List<int>() { 2 };
                    step.Values = new List<string>() { j.ToString() };
                    cstep.PrevStep = step;
                    Steps.Add(cstep);

                    if (j + 1 >= Lista.IntegerElements.Count)
                    {
                        ///////////////////////////////// for j conditie falsa ///////////////////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 6 };
                        step.Message = "Incrementam 'j'-ul.\nj = " + (j+1).ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este falsa, deci iesim din for.";
                        step.Command = "Attach|Update|ECHighlight|THClear";
                        step.AttachNames = new List<string>() { "j" };
                        step.AttachTo = new List<int>() { j + 1 };
                        step.Rows = new List<int>() { -1 };
                        step.VariableIndexes = new List<int>() { 2 };
                        step.Values = new List<string>() { (j + 1).ToString() };
                        step.HighlightedCountExtraC = new List<int>();
                        cstep.NextStep = step;
                        step = step.Clone();
                        step.Command = "Attach|Init|Update|THClear";
                        step.AttachNames = new List<string>() { "i", "j" };
                        step.AttachTo = new List<int>() { i, j + 1 };
                        step.Rows = new List<int>() { 2, -1 };
                        step.VariableIndexes = new List<int>() { 2, 1 };
                        step.Delimiter = 1;
                        step.UseDelimForUpdateInit = true;
                        step.VariableNames = new List<string>() { "j" };
                        step.Values = new List<string>() { (j + 1).ToString(), i.ToString() };
                        cstep.PrevStep = step;
                        Steps.Add(cstep);
                    }

                    if (i + 1 >= Lista.IntegerElements.Count - 1)
                    {
                        ///////////////////////////////// for i conditie falsa ///////////////////////////////////

                        cstep = new CStep();
                        step = new Step();
                        step.Highlight = new List<int>() { 5 };
                        step.Message = "Incrementam 'i'-ul.\ni = " + (i+1).ToString() + "\nlenSir - 1 = " + (Lista.IntegerElements.Count-1).ToString() + "\nCondita din for este falsa, deci iesim din for.";
                        step.Command = "Attach|Detach|Update|!Init|ECHighlight|THClear";
                        step.AttachNames = new List<string>() { "i", "j" };
                        step.AttachTo = new List<int>() { i + 1 };
                        step.Rows = new List<int>() { 2 };
                        step.Delimiter = 1;
                        step.VariableIndexes = new List<int>() { 1, 2 };
                        step.Values = new List<string>() { (i + 1).ToString() };
                        step.HighlightedCountExtraC = new List<int>();
                        cstep.NextStep = step;
                        step = step.Clone();
                        step.Command = "Attach|Update|THClear";
                        step.AttachNames = new List<string>() { "i" };
                        step.AttachTo = new List<int>() { i + 1 };
                        step.Rows = new List<int>() { 2 };
                        step.VariableIndexes = new List<int>() { 1 };
                        step.Values = new List<string>() { (i + 1).ToString() };
                        cstep.PrevStep = step;
                        Steps.Add(cstep);
                    }
                }
            }


            for (int i = 0; i < Lista.IntegerElements.Count; i++)
            {
                ///////////////////////////////// for i ///////////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 12 };
                step.Command = "Attach|Update|THClear";

                if (i != 0)
                {
                    step.Command += "|Highlight|ECHighlight|EAHighlight|AIHighlight";
                    step.HighlightedBlockIndexes = new List<int>();
                    step.HighlightedCountExtraC = new List<int>();
                    step.HighlightedCountExtraA = new List<int>();
                    step.HighlightedLabelIndexes = new List<int>();
                    step.Message = "Incrementam 'i'-ul.\ni = " + i.ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este adevarata, deci continuam parcurgerea.";
                }
                else
                    step.Message = "Parcurgem din nou sirul original impreuna cu 'count' folosind acelasi index 'i' care merge de la primul element din siruri pana la ultimul.";

                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { i.ToString() };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Highlight|ECHighlight|EAHighlight|AIHighlight|ABlockOverwrite|THClear";
                step.HighlightedBlockIndexes = new List<int>();
                step.HighlightedCountExtraC = new List<int>();
                step.HighlightedCountExtraA = new List<int>();
                step.HighlightedLabelIndexes = new List<int>();
                step.Swit = new Tuple<int, int>(count[i], -1);
                cstep.PrevStep = step;
                Steps.Add(cstep);

                /////////////////////////// sirAuxiliar[count[i] = sir[i] /////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 13 };
                step.Message = "Pe pozitia 'count[i]' din 'sirAuxiliar' punem valoarea de pe pozitia 'i' din sirul original.";
                step.Command = "Highlight|ECHighlight|EAHighlight|ABlockOverwrite|AIHighlight|THClear";
                step.HighlightedBlockIndexes = new List<int>() { i };
                step.HighlightedCountExtraC = new List<int>() { i };
                step.HighlightedCountExtraA = new List<int>() { count[i] };
                step.Swit = new Tuple<int, int>(count[i], Lista.IntegerElements[i]);
                step.HighlightedLabelIndexes = new List<int>() { count[i] };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Highlight|ECHighlight|EAHighlight|AIHighlight|Attach|Update|THClear";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i};
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { i.ToString() };
                cstep.PrevStep = step;
                Steps.Add(cstep);

                sirAuxiliar[count[i]] = Lista.IntegerElements[i];

                if (i + 1 >= Lista.IntegerElements.Count)
                {
                    ///////////////////////////////// for i conditie falsa ///////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 12 };
                    step.Message = "Incrementam 'i'-ul.\ni = " + (i+1).ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este falsa, deci iesim din for.";
                    step.Command = "Attach|Update|Highlight|ECHighlight|EAHighlight|AIHighlight|THClear";
                    step.HighlightedBlockIndexes = new List<int>();
                    step.HighlightedCountExtraC = new List<int>();
                    step.HighlightedCountExtraA = new List<int>();
                    step.HighlightedLabelIndexes = new List<int>();
                    step.AttachNames = new List<string>() { "i" };
                    step.AttachTo = new List<int>() { i + 1 };
                    step.Rows = new List<int>() { 2 };
                    step.VariableIndexes = new List<int>() { 1 };
                    step.Values = new List<string>() { (i + 1).ToString() };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Attach|Update|THClear";
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                }
            }

            for (int i = 0; i < Lista.IntegerElements.Count; i++)
            {
                ///////////////////////////////// for i ///////////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 15 };
                step.Command = "Attach|Update|THClear";

                if (i != 0)
                {
                    step.Command += "|Highlight|EAHighlight";
                    step.HighlightedBlockIndexes = new List<int>();
                    step.HighlightedCountExtraA = new List<int>();
                    step.Message = "Incrementam 'i'-ul.\ni = " + i.ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este adevarata, deci continuam parcurgerea.";
                }
                else
                    step.Message = "In acest moment 'sirAuxiliar' contine elementele sirului original, gata sortate, asa ca ne ramane sa copiem fiecare element de pe o pozitie 'i' din 'sirAuxiliar' " +
                        "pe aceeasi pozitie 'i' in sirul original. 'i' merge asadar de la primul element din siruri pana la ultimul.";

                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { i.ToString() };
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Highlight|EAHighlight|BlockOverwrite|THCLear";
                step.HighlightedBlockIndexes = new List<int>();
                step.HighlightedCountExtraA = new List<int>();
                step.Swit = new Tuple<int, int>(i, Lista.IntegerElements[i]);
                cstep.PrevStep = step;
                Steps.Add(cstep);

                ///////////////////////////////// sir[i] = sirAxiliar[i] ///////////////////////////////////

                cstep = new CStep();
                step = new Step();
                step.Highlight = new List<int>() { 16 };
                step.Message = "Copiem elementul de pe pozitia 'i' din 'sirAuxiliar' pe aceeasi pozitie 'i' in sirul original.";
                step.Command = "BlockOverwrite|Highlight|EAHighlight|THClear";
                step.HighlightedBlockIndexes = new List<int>() { i };
                step.HighlightedCountExtraA = new List<int>() { i };
                step.Swit = new Tuple<int, int>(i, sirAuxiliar[i]);
                cstep.NextStep = step;
                step = step.Clone();
                step.Command = "Highlight|EAHighlight|Attach|Update";
                step.AttachNames = new List<string>() { "i" };
                step.AttachTo = new List<int>() { i };
                step.Rows = new List<int>() { 2 };
                step.VariableIndexes = new List<int>() { 1 };
                step.Values = new List<string>() { i.ToString() };
                cstep.PrevStep = step;
                Steps.Add(cstep);

                Lista.IntegerElements[i] = sirAuxiliar[i];

                if (i + 1 >= Lista.IntegerElements.Count)
                {
                    ///////////////////////////////// for i conditie falsa ///////////////////////////////////

                    cstep = new CStep();
                    step = new Step();
                    step.Highlight = new List<int>() { 15 };
                    step.Message = "Incrementam 'i'-ul.\ni = " + (i + 1).ToString() + "\nlenSir = " + Lista.IntegerElements.Count.ToString() + "\nCondita din for este falsa, deci iesim din for.";
                    step.Command = "Attach|Update|Highlight|EAHighlight|THClear";
                    step.HighlightedBlockIndexes = new List<int>();
                    step.HighlightedCountExtraA = new List<int>();
                    step.AttachNames = new List<string>() { "i" };
                    step.AttachTo = new List<int>() { i+1 };
                    step.Rows = new List<int>() { 2 };
                    step.VariableIndexes = new List<int>() { 1 };
                    step.Values = new List<string>() { (i + 1).ToString() };
                    cstep.NextStep = step;
                    step = step.Clone();
                    step.Command = "Init|Attach|InitCountVisuals|THClear";
                    step.AttachNames = new List<string>() { "i" };
                    step.AttachTo = new List<int>() { i + 1 };
                    step.Rows = new List<int>() { 2 };
                    step.VariableNames = new List<string>() { "i" };
                    step.VariableIndexes = new List<int>() { 1 };
                    step.Values = new List<string>() { (i + 1).ToString() };
                    step.ExtraCountValues = count.ToList<int>();
                    step.ExtraAuxiliaryValues = sirAuxiliar.ToList<int>();
                    cstep.PrevStep = step;
                    Steps.Add(cstep);
                }

            }

            //////////////////////// sfarsit algoritm /////////////////////////

            step = new Step();
            step.Highlight = new List<int>() { 17 };
            step.Message = "Sfarsit! Sirul este sortat.";
            step.Command = "!Init|Detach|!InitCountVisuals|THClear";
            step.VariableIndexes = new List<int>() { 1 };
            step.AttachNames = new List<string>() { "i" };
            Steps.Add(new CStep(step, null));
        }
    }
}
