


namespace _64BitArray 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class BitArray64 : IEnumerable<int>
    {
        #region Fields

        private uint array;

        #endregion

        #region Constructors 
        public BitArray64(uint numberAsArray)
        {
            this.Array = numberAsArray; 
        }

        #endregion

        #region Properties
        public uint Array 
        { 
            get { return this.array; }

            set { this.array = value; } 
        }


        #endregion

        #region Indexes
        public int this[int indeks]
        {
            get
            {
                if (indeks >= this.Array.ToString().Length || indeks < 0)
                {
                    throw new IndexOutOfRangeException("Not a valid index");
                }
                else
                {
                    return (int)(this.Array.ToString()[indeks] - '0');
                }
            }
        }

        #endregion

        #region Methods
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.Array.ToString().Length; i++)
            {
                yield return (int)(this.Array.ToString()[i] - '0');
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var secondNumber = (BitArray64)obj;
            var secondNumberAsAString = secondNumber.Array.ToString();
            var firstNumberAsAString = this.Array.ToString();
            if (firstNumberAsAString.Length == secondNumberAsAString.Length)
            {
                for (int i = 0; i < firstNumberAsAString.Length; i++)
                {
                    if (firstNumberAsAString[i] != secondNumberAsAString[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashCode = (int)(this.Array.ToString()[0] - '0');            
            for (int i = 1; i < this.Array.ToString().Length; i++ ) 
            {
                hashCode = hashCode ^ (int)(this.Array.ToString()[i] - '0');
            }
            return hashCode;
        }

        #endregion

        #region Operators
        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray) 
        {
            return firstArray.Equals(secondArray);
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !(firstArray.Equals(secondArray));
        }

        #endregion
    }
}
