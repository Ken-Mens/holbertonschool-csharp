using System; 
  
class GFG { 
      
    public static void Main() 
    {     
        int[][] jagged_arr = new int[][] {
  
        new int[] {0, 1, 2, 3},
        new int[] {0, 1, 2, 3, 4, 5, 6},
        new int[] {0, 1}
     };
          

        int x = 0;
        for (; x < jagged_arr.Length; x++) 
        { 
    
            int y = 0;
            for (; y < jagged_arr[x].Length; y++) { 
                   if (y!= 0)
                   Console.Write(" ");
                   Console.Write(jagged_arr[x][y]); 
            } 
            Console.WriteLine(); 
        } 
    } 
}