// See https://aka.ms/new-console-template for more information
 int YearX = DateTime.Now.Year;
   int lpYr_lim = 0;
   //int lpYr_lim = 0;
   while (lpYr_lim < 20){
       YearX  =  YearX + 1;
     if(
       (YearX % 4 == 0)){
          lpYr_lim ++;
          Console.WriteLine(YearX);
       }
   } 
