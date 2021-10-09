namespace labGUI1
{
    public class Logic
    {
        public static string Solution(string word2, string unicchar)
        {
            string answer = "";
            foreach (var item1 in unicchar)
            {
                bool meet = false;
                foreach (var item2 in word2)
                {
                    if (item1 == item2)
                    {
                        meet = true;
                        break;
                    }
                }
                if (meet)
                    answer += "Да ";
                else
                    answer += "Нет ";
            }

            return answer;
        }

        public static string UnicSymbol(string word1)
        {
            string unicchar = word1;
            for (int i = 0; i < unicchar.Length; i++)
            {
                for (int j = 0; j < unicchar.Length; j++)
                {
                    if (i != j && unicchar[i] == unicchar[j])
                    {
                        unicchar = unicchar.Remove(j, 1);
                        i--;
                        break;
                    }
                }
            }

            return unicchar;
        }
    }
}
