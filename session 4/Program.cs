namespace session_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Array.Sort() 

            // For array sorting

            int[] numbers = { 5, 2, 9, 1 };
            Array.Sort(numbers); // 1,2,5,9




            #endregion

            #region Array.Reverse
            //To reverse the order of the elements of an array.

            int[] numbers1 = { 1, 2, 3 };
            Array.Reverse(numbers1); // { 3, 2, 1 }


            #endregion

            #region Array.IndexOf()
            //To find the location of a specific item

            int[] numbers2 = { 10, 20, 30 };
            int index = Array.IndexOf(numbers2, 20); // : 1


            #endregion

            #region Array.Exists()
            //To check if an item exists.

            int[] numbers3 = { 10, 20, 30 };
            bool exists = Array.Exists(numbers3, x => x == 20); // : true


            #endregion

            #region Array.Copy()

            //Copy elements from one array to another.

            int[] first = { 1, 2, 3 };
            int[] second = new int[3];
            Array.Copy(first, second, 3);

            #endregion

            #region Array.Clear()
            //To reset the elements of the array.

            int[] numbers4 = { 1, 2, 3 };
            Array.Clear(numbers4, 0, 2); // { 0, 0, 3 }





            #endregion

            #region Array.Find()
            //To find the first element that matches a condition.
            int[] numbers5 = { 10, 20, 30 };
            int result = Array.Find(numbers5, x => x > 15); // : 20

            #endregion

            #region Array.FindAll()

            //To find all items that match a given condition.


            int[] numbers6={ 10, 20, 30, 40 };
            int[] results6= Array.FindAll(numbers, x => x > 15); // { 20, 30, 40 }

            #endregion



        }
    }
}
