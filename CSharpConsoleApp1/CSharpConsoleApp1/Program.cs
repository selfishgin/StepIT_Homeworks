abstract class Storage
{
    public string MediaType { get; set; }
    public string Model { get; set; }

    public abstract double GetCapacity();

    public abstract void Copy(double fileSize);

    public abstract double FreeMemory();

    public void PrintDeviceInfo()
    {
        Console.WriteLine($"Media Type: {MediaType}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Capacity: {GetCapacity()} GB");
        Console.WriteLine($"Free Memory: {FreeMemory()} GB");
    }
}

class Flash : Storage
{
    public double USB3Speed { get; set; }
    public double Memory { get; set; }

    public override double GetCapacity()
    {
        return Memory;
    }

    public override void Copy(double fileSize)
    {
        int numDevicesNeeded = (int)Math.Ceiling(fileSize / Memory);
        double timeRequired = fileSize / USB3Speed;

        Console.WriteLine($"Number of flash drives needed: {numDevicesNeeded}");
        Console.WriteLine($"Time required: {timeRequired} hours");
    }

    public override double FreeMemory()
    {
        return Memory;
    }
}

class DVD : Storage
{
    public double ReadWriteSpeed { get; set; }
    public string Type { get; set; }

    public override double GetCapacity()
    {
        if (Type == "single")
            return 4.7;
        else if (Type == "double")
            return 9.0;
        else
            return 0;
    }

    public override void Copy(double fileSize)
    {
        int numDVDsNeeded = (int)Math.Ceiling(fileSize / GetCapacity());
        double timeRequired = fileSize / ReadWriteSpeed;

        Console.WriteLine($"Number of DVDs needed: {numDVDsNeeded}");
        Console.WriteLine($"Time required: {timeRequired} hours");
    }

    public override double FreeMemory()
    {
        return GetCapacity();
    }
}

class HDD : Storage
{
    public double USB2Speed { get; set; }
    public double TotalSize { get; set; }

    public override double GetCapacity()
    {
        return TotalSize;
    }

    public override void Copy(double fileSize)
    {
        double timeRequired = fileSize / USB2Speed;

        Console.WriteLine($"Time required: {timeRequired} hours");
    }

    public override double FreeMemory()
    {
        return TotalSize;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double fileSizeGB = 565 / 1024.0; 
        Storage[] devices = new Storage[]
        {
            new Flash { MediaType = "Flash Memory", Model = "Example Flash", USB3Speed = 5.0, Memory = 0.78 },
            new DVD { MediaType = "DVD", Model = "Example DVD", ReadWriteSpeed = 1.3, Type = "single" },
            new HDD { MediaType = "HDD", Model = "Example HDD", USB2Speed = 2.0, TotalSize = 500.0 }
        };

        foreach (var device in devices)
        {
            Console.WriteLine($"Device: {device.MediaType}");
            device.PrintDeviceInfo();
            device.Copy(fileSizeGB);
            Console.WriteLine();
        }
    }
}
