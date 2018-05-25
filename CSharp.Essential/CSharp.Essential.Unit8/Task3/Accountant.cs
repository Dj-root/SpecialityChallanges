namespace CSharp.Essential.Unit8
{
    public class Accountant
    {
        public static bool AskForBonus(Employees worker, int hours)
        {
            if ((int)worker < hours)
            {
                return true;
            }
            else
            {
                return false;
                
            }
            
        }
    }
}