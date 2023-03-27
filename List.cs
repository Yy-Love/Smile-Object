using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1、	创建一个集合长度为10，并找出最大值最小值的索引。

            //List<int> number = new List<int>();
            //Random random = new Random();
            //for (int i = 1; i >0; i++)
            //{
            //    int nums = random.Next(10);
            //    if (!number.Contains(nums))
            //    {

            //        number.Add(nums);
            //    }
            //    else
            //    {
            //        //跳出此次循环
            //        continue;
            //    }

            //    if (number.Count==10)
            //    {
            //        break;
            //    } 
            //}
            ////打印出集合的值 进行判断
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(number[i] + "\t");
            //}
            ////开始排序
            //int Maxnum = number[0];
            //int Minnum = number[0];
            //for (int j = number.Count - 1; j > -1; j--)
            //    {
            //        if (Maxnum > number[j])
            //        {
            //        }
            //        else
            //        {
            //            Maxnum = number[j];
            //        }
            //    if (Minnum < number[j])
            //    {
            //    }
            //    else
            //    {
            //        Minnum = number[j];
            //    }
            //}
            //int MaxIndex = number.IndexOf(Maxnum);
            //int MinIndex = number.IndexOf(Minnum);
            //Console.WriteLine();
            //Console.WriteLine("集合的最大值为{0}，索引为{1}", Maxnum, MaxIndex);
            //Console.WriteLine("集合的最小值为{0}，索引为{1}", Minnum, MinIndex);
            #endregion
            #region 2、	给指定数组nums [24，356，213，654，1234，23，4456，213] 排序，从大到小，建议使用冒泡排序
            //int[] nums = { 24,356,213,654,1234,23,4456,213 };
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int num;
            //    for (int j = nums.Length-1; j >i ; j--)
            //    {
            //        if (nums[i] < nums[j])
            //        {
            //            num = nums[j];
            //            nums[j] = nums[i];
            //            nums[i] = num;
            //        }
            //    }
            //}
            //Console.WriteLine("排序后的值为：");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write(nums[i]+",");
            //}

            #endregion
            #region 循环输出每个人的成绩

            //定义一个名字的字典

            Dictionary<int, string> Name = new Dictionary<int, string>()
            {
                {1,"张三" },
                {2,"李四" },
                {3,"王五" },
            };
            //定义一个成绩的字典

            Dictionary<int, string> Class = new Dictionary<int, string>()
            {
                {1,"语文" },
                {2,"数学" },
                {3,"英语" },
            }; 
            int ChineseSum = 0;
            var MathSum = 0;
            List<int> Eng = new List<int>();
           List<int> Chinese = new List<int>();
            List<int> Math = new List<int>();
            for (int i = 1; i <= Name.Count; i++)
            {
                Console.WriteLine("第{0}个人的姓名：{1}", i, Name[i]);
                for (int j = 1; j <= Name.Count; j++)
                {
                    Console.Write("第{0}个人的{1}成绩:", i, Class[j]);
                    int cj = int.Parse(Console.ReadLine());
                    if (j == 1)
                    {
                        Chinese.Add(cj);
                        ChineseSum += cj;
                    }
                    if (j == 2)
                    {
                        Math.Add(cj);
                        MathSum += cj;
                    }
                    if (j==3)
                    {
                        Eng.Add(cj);
                    }

                }
                
            }
            for (int i = 0; i < Eng.Count; i++)
            {
                Console.WriteLine(Eng[i]+",");
            }
            var Maxnum = Eng[0];
            for (int i = 1; i < Eng.Count; i++)
            {
                if (Maxnum > Eng[i])
                {
                }
                else
                {
                    Maxnum = Eng[i];
                }
            }
            int index = Eng.IndexOf(Maxnum);
            int Index = index + 1;
            var value = Name[Index];
            var AvgMath = MathSum / Name.Count;
            Console.WriteLine("语文总分为:{0}", ChineseSum);
            Console.WriteLine("数学平均分为:{0}", AvgMath);

            Console.WriteLine("英语成绩最高的人为:{0}，英语分数为：{1}，数学成绩为：{2}，语文成绩为：{3}", value, Eng[index], Math[index], Chinese[index]);
            #endregion
        }
    }
}
