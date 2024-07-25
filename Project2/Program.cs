namespace Project2
{
    internal class Program
    {
      public  static void Main(string[] args)
        {
         MatrixDemo matrices = new MatrixDemo();
            matrices.matrix();
            MaxDemo max = new MaxDemo();
            max.max();
            ColSum col=new ColSum();
            col.sum();
            RowSum row=new RowSum();
            row.sum();
            SumandAvg sum=new SumandAvg();
            sum.avg();
        }
    }
}
