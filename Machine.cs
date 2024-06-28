using System;
using System.Collections.Generic;

class Machine {
		public string SerialNo { get; set; }
		public string Make { get; set; }
		public int Price { get; set; }
		public string Model { get; set; }

		public override string ToString() {
			return string.Format("Serial No: {0}\nMake: {1}\nModel: {2}\nPrice: {3}", SerialNo, Make, Model, Price);
		}

}

class MachineDatabase {
	private List<Machine> laptops = new List<Machine>();

	public void RegisterDevice(Machine mac) {
		laptops.Add(mac);
		return;
	}

	public void UpdateDeviceDetails(string slno, Machine mac) {
		for (int i = 0; i < laptops.Count; i++) {
			if (laptops[i].SerialNo.Equals(slno)) {
				laptops[i].Make = mac.Make;
				laptops[i].Model = mac.Model;
				laptops[i].Price = mac.Price;
				return;
			}
		}
		throw new Exception("Machine not found!");
	}

	public Machine[] GetAllRegisteredDevices() {
		return laptops.ToArray();
	}
}

