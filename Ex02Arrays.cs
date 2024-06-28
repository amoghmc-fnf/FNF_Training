using System;
namespace SampleConApp
{
	class ArraysExample {
		static void creatingArrayAtRuntime() {
			Console.WriteLine("Enter Array size");
			int size = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter CTS type for array");
			Type arrayType = Type.GetType(Console.ReadLine());
			if (arrayType == null) {
				Console.WriteLine("Not a valid type of .NET");
				return;
			}
			Array array = Array.CreateInstance(arrayType, size);
			for (int i = 0; i < size; i++) {
				Console.WriteLine("Enter value at position {0} of the type {1}", i, arrayType.FullName);
				object value = Convert.ChangeType(Console.ReadLine(), arrayType);
				array.SetValue(value, i);
			}
			Console.WriteLine("All values are set, lets read them");
			foreach (var item in array)
				Console.WriteLine(item);
		}
		static void displayArray() {
			Console.WriteLine("Enter size of array");
			int size = int.Parse(Console.ReadLine());
			
			int[] elements = new int[size];
			for (int i = 0; i < size; i++) {
				Console.WriteLine("Enter the value at position {0}", i);
				elements[i] = int.Parse(Console.ReadLine());
			}
			
			Console.WriteLine("All values are set");
			foreach (int item in elements)
				Console.WriteLine("{0}", item);
			
		}
		static void Main() {
			// displayArray();
			creatingArrayAtRuntime();
		}
	}
}
