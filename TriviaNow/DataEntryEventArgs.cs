using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    //class DataEntryEventArgs will encapsulate a question
    class DataEntryEventArgs : EventArgs
    {
        private Question question;

        public DataEntryEventArgs(Question question)
        {
            this.Question = question;
        }

        public Question Question { get => question; set => question = value; }
    }
}
