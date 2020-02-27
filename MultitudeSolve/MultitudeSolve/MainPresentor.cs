using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultitudeSolve
{
    class MainPresentor
    {
        private readonly IMainForm _view;
        private readonly IMessageService _messageService;

        public MainPresentor(IMainForm view, IMessageService messageService)
        {
            _view = view;
            _messageService = messageService;

            _view.SolveCrossing += new EventHandler(_view_SolveCrossing);
            _view.SolveAssociation += _view_SolveAssociation;
            _view.SolveDifference += _view_SolveDifference;
            _view.SolveSymetricDifference += _view_SolveSymetricDifference;
            _view.SolveCartesianWork += _view_SolveCartesianWork;
            _view.SolveAddition += _view_SolveAddition;
            _view.SolveComposition += _view_SolveComposition;
            _view.SolveAddress += _view_SolveAddress;
        }

        private void _view_SolveAddress(object sender, EventArgs e)
        {
            if (_view.CkeckFirstRelation)
            {
                Relation FirstRelation = new Relation();

                for (int i = 0; i < _view.Content_4.Length; i += 2)
                    FirstRelation.LeftElements.Add(_view.Content_4[i]);
                for (int i = 1; i < _view.Content_4.Length; i += 2)
                    FirstRelation.RightElements.Add(_view.Content_4[i]);
                for (int i = 0; i < FirstRelation.LeftElements.Count; i++)
                    _view.ResultContent += '(' + FirstRelation.RightElements[i] + ',' + FirstRelation.LeftElements[i] + ')';

                _view.ResultContent = '{' + _view.ResultContent + '}' + '\r' + '\n' + '\r' + '\n' + "----------------------------" + '\r' + '\n';
                _view.ResultContent += "Матричный вид" + '\r' + '\n' + '\r' + '\n' + "      " ;

                string[,] checkedFLD = new string[FirstRelation.RightElements.Count, FirstRelation.LeftElements.Count];

                for (int i = 0; i < FirstRelation.RightElements.Count; i++)
                {
                    for (int j = 0; j < FirstRelation.LeftElements.Count; j++)
                        if (FirstRelation.RightElements.IndexOf(FirstRelation.RightElements[i]) == FirstRelation.LeftElements.IndexOf(FirstRelation.LeftElements[j]))
                            checkedFLD[i, j] = "1";
                        else checkedFLD[i, j] = "0";
                }
                for (int i = 0; i < FirstRelation.RightElements.Count; i++)
                    if (FirstRelation.RightElements.IndexOf(FirstRelation.RightElements[i]) != FirstRelation.RightElements.LastIndexOf(FirstRelation.RightElements[i]))
                        FirstRelation.RightElements.Remove(FirstRelation.RightElements[i]);
                for (int i = 0; i < FirstRelation.LeftElements.Count; i++)
                    if (FirstRelation.LeftElements.IndexOf(FirstRelation.LeftElements[i]) != FirstRelation.LeftElements.LastIndexOf(FirstRelation.LeftElements[i]))
                        FirstRelation.LeftElements.Remove(FirstRelation.LeftElements[i]);



                for (int i = 0; i < FirstRelation.RightElements.Count; i++)
                    _view.ResultContent += FirstRelation.RightElements[i] + " ";
                _view.ResultContent += " " + '\r' + '\n'+ '\r' + '\n';


                for (int j = 0; j < FirstRelation.LeftElements.Count; j++)
                {
                    _view.ResultContent += FirstRelation.LeftElements[j] + "   ";
                    for (int i = 0; i < checkedFLD.GetLength(1); i++)
                        _view.ResultContent += checkedFLD[j, i] + " ";
                    _view.ResultContent += "" + '\r' + '\n';

                }


            }
            else if (!_view.CheckSecondMultitude)
            {
                _messageService.ShowErrorAddition("Возможные ошибки:\n1. Обращение заполнено не в первом поле для бинарных отношений\n2. Не заполнено поле");
                return;
            }
        }

        private void _view_SolveComposition(object sender, EventArgs e)
        {
            if (_view.CheckRelation)
            {
                Relation FirstRelation = new Relation();
                Relation SecondRelation = new Relation();
                Relation contentChanged = new Relation();

                for (int i = 0; i < _view.Content_4.Length; i += 2)
                    FirstRelation.LeftElements.Add(_view.Content_4[i]);
                for (int i = 0; i < _view.Content_5.Length; i += 2)
                    SecondRelation.LeftElements.Add(_view.Content_5[i]);
                for (int i = 1; i < _view.Content_4.Length; i += 2)
                    FirstRelation.RightElements.Add(_view.Content_4[i]);
                for (int i = 1; i < _view.Content_5.Length; i += 2)
                    SecondRelation.RightElements.Add(_view.Content_5[i]);

                for (int i = 0; i < FirstRelation.RightElements.Count; i++)
                    for (int j = 0; j < SecondRelation.LeftElements.Count; j++)
                    {
                        if (FirstRelation.RightElements[i] == SecondRelation.LeftElements[j])
                        {
                            contentChanged.LeftElements.Add(FirstRelation.LeftElements[i]);
                            contentChanged.RightElements.Add(SecondRelation.RightElements[j]);
                        }
                    }

                for (int i = 0; i < contentChanged.LeftElements.Count; i++)
                    _view.ResultContent += '(' + contentChanged.LeftElements[i] + ',' + contentChanged.RightElements[i] + ')';

                _view.ResultContent = '{' + _view.ResultContent + '}';
            }
            else
            {
                _messageService.ShowErrorRelation("Не заполнено ни одно из бинарных отношений \nБинарное отношение заполняется по образцу : (a,b),(a,b)");
                return;
            }
        }

        private void _view_SolveAddition(object sender, EventArgs e)
        {
            if (_view.CheckUniversal)
            {
                Multitude FirstMultitude = new Multitude();
                Multitude Universal = new Multitude();

                for (int i = 0; i < _view.Content.Length; i++)
                    FirstMultitude.Elements.Add(_view.Content[i]);
                for (int i = 0; i < _view.Content_3.Length; i++)
                    Universal.Elements.Add(_view.Content_3[i]);

                int count = 0;
                if (Universal.Elements.Count > FirstMultitude.Elements.Count)
                {
                    for (int i = 0; i < FirstMultitude.Elements.Count; i++)
                    {
                        if (Universal.Elements[i] != FirstMultitude.Elements[i])
                        {
                            count++;
                            break;
                        }
                    }
                }
                else
                {
                    _messageService.ShowExclamation("Universal не является U для данного множества");
                    return;
                }

                if (count > 0)
                {
                    _messageService.ShowExclamation("U не содержит некоторые элементы принадлежашие множеству");
                    return;
                }


                List<string> contentCHanged = new List<string>();
                Universal.Elements.RemoveAll(x => FirstMultitude.Elements.Contains(x));

                for (int i = 0; i < Universal.Elements.Count; i++)
                {
                    _view.ResultContent += Universal.Elements[i] + ',';
                }
                _view.ResultContent = '(' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + ')';

            }
            else
            {
                _messageService.ShowExclamation("Укажите Universal");
                return;
            }
        }

        private void _view_SolveCartesianWork(object sender, EventArgs e)
        {
            if (!_view.CheckFirstMultitude || !_view.CheckSecondMultitude)
            {
                _messageService.ShowExclamation("Одно из множеств не заполнено");
                return;
            }
            else
            {
                Multitude FirstMultitude = new Multitude();
                Multitude SecondMultitude = new Multitude();

                for (int i = 0; i < _view.Content.Length; i++)
                    FirstMultitude.Elements.Add(_view.Content[i]);
                for (int i = 0; i < _view.Content_2.Length; i++)
                    SecondMultitude.Elements.Add(_view.Content_2[i]);

                List<string> contentChanged = new List<string>();
                for (int i = 0; i < FirstMultitude.Elements.Count; i++)
                    for (int j = 0; j < FirstMultitude.Elements.Count; j++)
                        contentChanged.Add('(' + FirstMultitude.Elements[i] + ',' + SecondMultitude.Elements[j] + ')');

                for (int i = 0; i < contentChanged.Count; i++)
                    _view.ResultContent += contentChanged[i] + ',';
                _view.ResultContent = '{' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + '}';
            }
        }

        private void _view_SolveSymetricDifference(object sender, EventArgs e)
        {
            if (!_view.CheckFirstMultitude || !_view.CheckSecondMultitude)
            {
                _messageService.ShowExclamation("Одно из множеств не заполнено");
                return;
            }
            else
            {
                Multitude FirstMultitude = new Multitude();
                Multitude SecondMultitude = new Multitude();

                for (int i = 0; i < _view.Content.Length; i++)
                    FirstMultitude.Elements.Add(_view.Content[i]);
                for (int i = 0; i < _view.Content_2.Length; i++)
                    SecondMultitude.Elements.Add(_view.Content_2[i]);

                List<string> contentChanged = new List<string>();
                for (int i = 0; i < _view.Content.Length; i++)
                {
                    contentChanged.Add(FirstMultitude.Elements[i]);
                }
                for (int i = 0; i < _view.Content_2.Length; i++)
                    contentChanged.Add(SecondMultitude.Elements[i]);
                int u = 1;
                while (u < contentChanged.Count)
                {
                    int j = 0;
                    bool remove = false;
                    while (j < u && !remove)
                    {
                        if (contentChanged[u].Equals(contentChanged[j]))
                        {
                            remove = true;
                        }
                        j++;
                    }
                    if (remove)
                    {
                        contentChanged.RemoveAt(u);
                    }
                    else
                    {
                        u++;
                    }
                }

                contentChanged.RemoveAll(x => SecondMultitude.Elements.Contains(x) && FirstMultitude.Elements.Contains(x));
                for (int i = 0; i < contentChanged.Count; i++)
                    _view.ResultContent += contentChanged[i] + ',';
                _view.ResultContent = '(' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + ')';
            }
        }

        private void _view_SolveDifference(object sender, EventArgs e)
        {
            if (!_view.CheckFirstMultitude || !_view.CheckSecondMultitude)
            {
                _messageService.ShowExclamation("Одно из множеств не заполнено");
                return;
            }
            else
            {
                Multitude FirstMultitude = new Multitude();
                Multitude SecondMultitude = new Multitude();

                for (int i = 0; i < _view.Content.Length; i++)
                    FirstMultitude.Elements.Add(_view.Content[i]);
                for (int i = 0; i < _view.Content_2.Length; i++)
                    SecondMultitude.Elements.Add(_view.Content_2[i]);

                FirstMultitude.Elements.RemoveAll(x => SecondMultitude.Elements.Contains(x));

                for (int i = 0; i < FirstMultitude.Elements.Count; i++)
                {
                    _view.ResultContent += FirstMultitude.Elements[i] + ',';
                }
                _view.ResultContent = '(' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + ')';
            }
        }

        private void _view_SolveAssociation(object sender, EventArgs e)
        {
            if (!_view.CheckFirstMultitude || !_view.CheckSecondMultitude)
            {
                _messageService.ShowExclamation("Одно из множеств не заполнено");
                return;
            }
            else
            {
                Multitude FirstMultitude = new Multitude();
                Multitude SecondMultitude = new Multitude();

                for (int i = 0; i < _view.Content.Length; i++)
                    FirstMultitude.Elements.Add(_view.Content[i]);
                for (int i = 0; i < _view.Content_2.Length; i++)
                    SecondMultitude.Elements.Add(_view.Content_2[i]);
                List<string> contentChanged = new List<string>();
                for (int i = 0; i < _view.Content.Length; i++)
                {
                    contentChanged.Add(FirstMultitude.Elements[i]);
                }
                for (int i = 0; i < _view.Content_2.Length; i++)
                    contentChanged.Add(SecondMultitude.Elements[i]);
                int u = 1;
                while (u < contentChanged.Count)
                {
                    int j = 0;
                    bool remove = false;
                    while (j < u && !remove)
                    {
                        if (contentChanged[u].Equals(contentChanged[j]))
                        {
                            remove = true;
                        }
                        j++;
                    }
                    if (remove)
                    {
                        contentChanged.RemoveAt(u);
                    }
                    else
                    {
                        u++;
                    }
                }
                for (int i = 0; i < contentChanged.Count; i++)
                    _view.ResultContent += contentChanged[i] + ',';
                _view.ResultContent = '(' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + ')';
            }
        }

        void _view_SolveCrossing(object sender, EventArgs e)
        {
            if (!_view.CheckFirstMultitude || !_view.CheckSecondMultitude)
            {
                _messageService.ShowExclamation("Одно из множеств не заполнено");
                return;
            }
            else
            {
                Multitude FirtstMultitude = new Multitude();
                Multitude SecondMultitude = new Multitude();

                string contentChanged = _view.ResultContent;
                string[] content = _view.Content;
                for (int i = 0; i < content.Length; i++)
                    FirtstMultitude.Elements.Add(content[i]);
                for (int i = 0; i < _view.Content_2.Length; i++)
                    SecondMultitude.Elements.Add(_view.Content_2[i]);

                for (int i = 0; i < FirtstMultitude.Elements.Count; i++)
                    for (int j = 0; j < SecondMultitude.Elements.Count; j++)
                    {
                        if (FirtstMultitude.Elements[i] == SecondMultitude.Elements[j]) contentChanged += FirtstMultitude.Elements[i] + ',';
                    }
                _view.ResultContent = contentChanged;
                _view.ResultContent = '(' + _view.ResultContent.Substring(0, _view.ResultContent.Length - 1) + ')';
            }
        }
    }
}
