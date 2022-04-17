using System;
using System.Collections.Generic;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Group> groups = new List<Group>();
            List<Student> students = new List<Student>();


            while (true)
            {
                Console.WriteLine("1. Yeni qrup yarat" +
                    "\n2. Qrupların siyahısını goster" +
                    "\n3. Qrup üzərində düzəliş etmək" +
                    "\n4. Qrupdakı tələbələrin siyahısını göstər" +
                    "\n5. Bütün telebelerin siyahısını göstər" +
                    "\n6. Telebe yarat");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:                               //1.Yeni qrup yarat
                        Group grp1 = new Group();
                        groups.Add(grp1);
                        
                        break;
                    case 2:                              //2. Qrupların siyahısını goster
                        foreach (var item in groups)
                        {
                            Console.WriteLine($"Group No: {item.No}" +
                                $"\nGroup Category: {item.Category}" +
                                $"\nGroup Limit: {item.Limit}" +
                                $"\nNumber of students: {students.Count}\n\n");
                        }
                        break;
                    case 3:                             //3. Qrup üzərində düzəliş etmək
                        Console.WriteLine("Please enter Group No");
                        string GroupNo = Console.ReadLine();
                        bool isExist = false;
                        bool NewIsExist = false;
                        foreach (var item in groups)
                        {
                            if (GroupNo == item.No)
                            {
                                isExist = true;
                                Console.WriteLine("Please enter NEW Group No");
                                string NewGroupNo = Console.ReadLine();
                                foreach (var item1 in groups)
                                {
                                    if (NewGroupNo == item1.No)
                                    {
                                        NewIsExist = true;
                                        Console.WriteLine("This group no is already exist!!! Please enter NEW Group No again!");
                                        NewGroupNo = Console.ReadLine();
                                        item.No = NewGroupNo;
                                        break;
                                    }

                                }
                                if (!NewIsExist)
                                {
                                    item.No = NewGroupNo;
                                    Console.WriteLine("Group No is changed.");
                                }

                                break;
                            }

                        }
                        if (!isExist)
                        {
                            Console.WriteLine("This group is not exist!!");
                        }
                        break;

                    case 4:                         //4. Qrupdakı tələbələrin siyahısını göstər
                        Console.WriteLine("Please enter Group No:");
                        string GroupNO = Console.ReadLine();
                        bool check = false;
                        foreach (var item in groups)
                        {
                            if (GroupNO == item.No)
                            {
                                check = true;
                                Console.WriteLine(item.students);
                            }
                        }
                        if (!check)
                        {
                            Console.WriteLine("This group is not exist!!!\n");
                            
                        }


                        break;
                    case 5:                          //5. Bütün tələbələrin siyahısını göstər
                        Console.WriteLine("All student's datas");
                        foreach (var item in groups)
                        {
                            foreach (var item1 in item.students)
                            {
                                Console.WriteLine($"FullName:{item1.FullName}\nGroup No:{item1.GroupNo}\nType:{item1.Type}");
                            }
                        }
                        break; 
                    case 6:                         //6. Tələbə yarat
                        Console.WriteLine("Enter new student's data:");
                        Student stu = new Student();
                        Console.WriteLine("Enter student's group No:");
                        string groupNO = Console.ReadLine();
                        foreach (var item in groups)
                        {
                            if (item.No== groupNO)
                            {
                                item.students.Add(stu);
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Please select correct number!!!");
                        break;
                }
            }
        }



    }
}
