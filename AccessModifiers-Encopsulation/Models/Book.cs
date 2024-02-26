

using System.Runtime.CompilerServices;

namespace AccessModifiers_Encopsulation.Models
{
    internal class Book:BaseEntity
    {
        //Constanta deyer vermelisen
        public const string title="Bashliq";
        public readonly string author="salam";

        public Book()
        {
            author = "sagol";
        }
    }
}
