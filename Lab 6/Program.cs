using Lab_6;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    internal class Program
    {
        //1

        //static List<Student> students = new List<Student>();
        //static void Main(string[] args)
        //{
            
        //    int choice = 0;
        //    do
        //    {
        //        Console.WriteLine("1. Add Student");
        //        Console.WriteLine("2. Display Students");
        //        Console.WriteLine("3. Search Student");
        //        Console.WriteLine("4. Update Student");
        //        Console.WriteLine("5. Delete Student");
        //        Console.WriteLine("6. Exit");
        //        Console.Write("Enter your choice: ");
        //        choice = Convert.ToInt32(Console.ReadLine());

        //        switch (choice)
        //        {
        //            case 1:
        //                // Add Student
        //                AddStudent();
        //                break;
        //            case 2:
        //                // Display Students
        //                DisplayStudents();
        //                break;
        //            case 3:
        //                // Search Student
        //                SearchStudent();
        //                break;
        //            case 4:
        //                // Update Student
        //                UpdateStudent();
        //                break;
        //            case 5:
        //                // Delete Student
        //                DeleteStudent();
        //                break;
        //            case 6:
        //                Console.WriteLine("Exiting...");
        //                return;
        //            default:
        //                Console.WriteLine("Invalid choice. Please try again.");
        //                break;
        //        }
        //    } while (choice != 6);
        //}

        //// Add Student
        //static void AddStudent()
        //{
        //    Console.Write("Enter Student ID: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Enter Student Name: ");
        //    string name = Console.ReadLine();
        //    Console.Write("Enter Student Age: ");
        //    int age = Convert.ToInt32(Console.ReadLine());
        //    students.Add(new Student(id, name, age));
        //    Console.WriteLine("Student added successfully.");
        //}

        //// Display Students
        //static void DisplayStudents()
        //{
        //    if (students.Count == 0)
        //    {
        //        Console.WriteLine("No students to display.");
        //        return;
        //    }
        //    foreach (var student in students)
        //    {
        //        Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}");
        //    }
        //}

        //// Search Student
        //static void SearchStudent()
        //{
        //    Console.Write("Enter Student ID to search: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    var student = students.Find(s => s.id == id);
        //    if (student != null)
        //    {
        //        Console.WriteLine($"ID: {student.id}, Name: {student.name}, Age: {student.age}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student not found.");
        //    }
        //}

        //// Update Student
        //static void UpdateStudent()
        //{
        //    Console.Write("Enter Student ID to update: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    var student = students.Find(s => s.id == id);
        //    if (student != null)
        //    {
        //        Console.Write("Enter new name: ");
        //        student.name = Console.ReadLine();
        //        Console.Write("Enter new age: ");
        //        student.age = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("Student updated successfully.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student not found.");
        //    }
        //}

        //// Delete Student
        //static void DeleteStudent()
        //{
        //    Console.Write("Enter Student ID to delete: ");
        //    int id = Convert.ToInt32(Console.ReadLine());
        //    var student = students.Find(s => s.id == id);
        //    if (student != null)
        //    {
        //        students.Remove(student);
        //        Console.WriteLine("Student deleted successfully.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Student not found.");
        //    }
        //}



        //2 
        static void Main(string[] args)
        {
            List<CartItem> cart = new List<CartItem>();
            int choice = 0;
            do
            {
                Console.WriteLine("1. Add Item to Cart");
                Console.WriteLine("2. Remove Item from Cart");
                Console.WriteLine("3. View Cart");
                Console.WriteLine("4. Calculate Total Amount");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        
                        AddItemToCart(cart);
                        break;
                    case 2:
                        
                        RemoveCartItems(cart);
                        break;
                    case 3:
                        ViewCart(cart);
                        break;
                    case 4:
                        CalculateTotalAmount(cart);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 3);
        }
        static void AddItemToCart(List<CartItem> cart)
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();
            Console.Write("Enter item price: ");
            double price = Convert.ToDouble(Console.ReadLine());
            cart.Add(new CartItem(name, price));
            Console.WriteLine("Item added to cart.");
        }
        static void RemoveCartItems(List<CartItem> cart)
        {
            Console.Write("Enter item name to remove: ");
            string name = Console.ReadLine();
            var itemToRemove = cart.Find(item => item.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine("Item removed from cart.");
            }
            else
            {
                Console.WriteLine("Item not found in cart.");
            }
        }
        static void ViewCart(List<CartItem> cart)
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("Cart is empty.");
                return;
            }
            Console.WriteLine("Items in Cart:");
            foreach (var item in cart)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}");
            }
        }

        static void CalculateTotalAmount(List<CartItem> cart)
        {
            double totalAmount = 0;
            foreach (var item in cart)
            {
                totalAmount += item.Price;
            }
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }
}