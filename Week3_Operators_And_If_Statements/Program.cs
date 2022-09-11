public class Operators
{

    // Using the ADDITION OPERATOR,
    // add x and y, then return the result.
    public int SumOfTwoNumbers(int x, int y)
    {
        var result = x+ y;
        return result;
    }

    
    // Using the SUBTRACTION OPERATOR,
    // subtract y from x, then return the result.
    public int DifferenceOfTwoNumbers(int x, int y)
    {
        throw new NotImplementedException();
    }

    
    // Using the MULTIPLICATION OPERATOR,
    // multiply x and y, then return the result
    public int ProductOfTwoNumbers(int x, int y)
    {
        throw new NotImplementedException();
    }
    
    // Using the DIVISION OPERATOR,
    // divide y from x.  If y is zero then
    // return null
    public decimal? QuotientOfTwoNumbers(decimal x, decimal y)
    {
        throw new NotImplementedException();
    }

    // Using the REMAINDER OPERATOR,
    // return remainder of x divided by y.  If y is 
    // zero, return null
    public int? DividendOfTwoNumbers(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Using the GREATER THAN OPERATOR,
    // check if x is greater than y.  If so, return true.
    // Otherwise, return false
    public bool IsXGreaterThanY(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Using the LESS THAN OPERATOR,
    // check if x is less than y.  If so, return true.
    // Otherwise, return false
    public bool IsXLessThanY(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Using the GREATER THAN OR EQUAL TO OPERATOR
    // check if x is greater than or equal to y.
    // If so, return true. Otherwise, return false
    public bool IsXGreaterThanOrEqualToY(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Using the LESS THAN OR EQUAL TO OPERATOR,
    // check if x is less than or equal to y.
    // If so, return true. Otherwise, return false
    public bool IsXLessThanOrEqualToY(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Using the EQUALITY OPERATOR,
    // check if x and y are equal.  If so
    // return true.  Otherwise return false.
    public bool AreXAndYEqual(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Check if x or y are greater than 0.
    // If so, return true, otherwise return false.
    // You will need to use the CONDITIONAL LOGICAL OR
    // and GREATER THAN OPERATORS to do so.
    public bool IsXOrYGreaterThanZero(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Check if x and y are greater than 0.
    // If so, return true, otherwise return false.
    // You will need to use the CONDITIONAL LOGICAL AND
    // along with the GREATER THAN OPERATORS to do so.
    public bool AreXAndYGreaterThanZero(int x, int y)
    {
        throw new NotImplementedException();
    }

    // using an INEQUALITY OPERATOR, check if x
    // and y are not equal.  If so, return true.
    // Otherwise, return false.
    public bool IsXNotEqualToY(int x, int y)
    {
        throw new NotImplementedException();
    }

    // Referencing the CustomerType enum below, check that
    // a given customer is elibible for a discount.
    // Students get a 10% discount
    // Seniors get a 15% discount
    // Military gets a 20% discount
    // Children get a 100% discount
    // Adults get no discount and should return null

    // Use IF/ELSE IF STATEMENTS to check your customer type and 
    // return a discount based on what type they are.
    // Make sure to use an ELSE STATEMENT (not ELSE IF) at the end.

    // You will need to make use of explicit casting to ensure the 
    // values you are returning are the correct data type.  You can
    // read more about explicit conversion in the link below:
    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/casting-and-type-conversions#explicit-conversions



    public decimal? ReturnCustomerTypeDiscountRate(CustomerType customerType)
    {
        throw new NotImplementedException();
    }

    
    // perform the same checks against your customer type as before
    // but this time use a switch staement to do so.  You should make
    // use of at least one default statement.  
    public decimal? ReturnCustomerTypeDiscountRateSwitch(CustomerType customerType)
    {
        throw new NotImplementedException();
    }

    public enum CustomerType
    {
        Student,
        Senior,
        Child,
        Military,
        Adult
    }
}