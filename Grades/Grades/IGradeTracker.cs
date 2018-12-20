using System.Collections;
using System.IO;

namespace Grades
{
    internal interface IGradeTracker : IEnumerable
    {
          void AddGrade(float grade);
          GradeStatistics CommputeStatics();
          void WritrGrades(TextWriter destination);
          string name { get; set; }
    }
}