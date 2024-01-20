namespace MathService;

public class FactorialService{
    public static int getFactorialOf(int n){
        if (n==0)
            return 1;
        if (n<0)
            throw new Exception("Negative factorial is undefined");

        return n * getFactorialOf(n-1);
    }
    
}
