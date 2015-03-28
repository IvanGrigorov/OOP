using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    interface IComment
    {
        string Comment { get; set; }

        void AddComment(string comment);

        void ChangeComment(string newComment);
    }
}
