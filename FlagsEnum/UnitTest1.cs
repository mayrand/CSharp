namespace FlagsEnum;
//Todo: Fix that
public class UnitTest1
{
    [Flags]
    public enum Days
    {
        None      = 0b_0000_0000,  // 0
        Monday    = 0b_0000_0001,  // 1
        Tuesday   = 0b_0000_0010,  // 2
        Wednesday = 0b_0000_0100,  // 4
        Thursday  = 0b_0000_1000,  // 8
        Friday    = 0b_0001_0000,  // 16
        Saturday  = 0b_0010_0000,  // 32
        Sunday    = 0b_0100_0000,  // 64
        All       = 0b_1000_0000, // 128
        Weekend   = Saturday | Sunday
    }

    /*public class FlagsEnumExample
    {
        public static void Main()
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);
            // Output:
            // Monday, Wednesday, Friday

            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");
            // Output:
            // Join a meeting by phone on Friday

            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");
            // Output:
            // Is there a meeting on Tuesday: False

            var a = (Days)37;
            Console.WriteLine(a);
            // Output:
            // Monday, Wednesday, Saturday
        }
    }*/
    [Fact]
    public void Test1()
    {
        var value = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday | Days.Weekend;
        //value = value & ~Days.Monday;
        Assert.True((value & Days.All)==Days.All);
    }
}