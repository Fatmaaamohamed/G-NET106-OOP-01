namespace G_NET106_OOP_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            /* a) The DeliveryAddress variable will remain the same after modifing the variable that equal to
             
             DeliveryAddress variable beacuse DeliveryAddress is defined as  struct and struct is value type

            (copied by value ,each copy is independent). */


            /* B) Both variables will be modified because Customer variable is defined as class and class is
       
             refrence type.
            */

            #endregion


            #region Question02
            /*
             A) 1.All fields (Description, Weight, and DeliveryFee) are declared as public. 
            External code can access and modify internal state directly without any validation or control .

            2.Because Weight and DeliveryFee are public fields, external code can assign invalid or
            logical boundary-breaking values (e.g., negative weight like Weight = -15.0 or negative fee like DeliveryFee = -50.0m).
             
            3.Changing the internal implementation details in the future
            will break any external code directly accessing these fields.


            B) Private fields and public properties improve this design by enforcing data validation 
            (preventing invalid state such as negative Weight or DeliveryFee inside set accessors),
            controlling access permissions (restricting modifications via read-only or init-only accessors),
            encapsulating internal implementation (allowing internal storage changes without breaking external code), 
            and enabling computed values (dynamically calculating values like fee based on weight).
             
             */
            #endregion
        }
    }
}
