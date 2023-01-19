//1 / 3 - Elemento Majoritário - DEV Davez
using System;
using System.Text.RegularExpressions;

/*
Esse trecho pertence ao metodo Main, principal
*/
        //declaração teste;
        //int n = int.Parse("5");

        //declaração da atividade;
        int n = int.Parse(Console.ReadLine());
        
        int[] num = new int[n];
    
        for (int i = 0; i < num.Length ; i++)
        {
            //declaração teste;
            // int x, y;
            // x = 7;
            // y = 5;
            

            // if(i == 0){
            //     num[i] = x;
            // }else if (i == 1){
            //     num[i] = x;
            // }else if (i == 2){
            //     num[i] = x;
            // }else if (i == 3){
            //     num[i] = y;
            // }else{
            //     num[i] = y;
            // }
            

            //declaração da atividade;
            num[i] = int.Parse(Console.ReadLine());
            
        }
        Console.WriteLine(MajorityElement(num));

    static int MajorityElement(int[] nums)
    {
        int major = 0;
        int referencia = nums[0];
        int count = 1;
        int maxCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (referencia != nums[i])
            {
                referencia = nums[i];
            }
            for(int j = 0;j < nums.Length; j++){

                if (nums[i] == nums[j])
                {
                    count++;
                    if(count > maxCount){
                        major = nums[i]; 
                        maxCount++;
                    }
                }               
            } 
            count = 1;           
        }
        return  major;
    }