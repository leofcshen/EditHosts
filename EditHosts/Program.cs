using System.Diagnostics;

namespace EditHosts;

internal class Program {
  static void Main(/*string[] args*/) {
    SV_Process.RunAsAdmin("notepad.exe", @"C:\Windows\System32\drivers\etc\hosts");
  }
}

public class SV_Process {
  public static void RunAsAdmin(string fileName, string? arguments = null) {
    var processInfo = new ProcessStartInfo {
      FileName = fileName,
      Arguments = arguments,
      // 以管理員身份運行
      Verb = "runas",
      // 必須設為 true 才能使用 "runas"
      UseShellExecute = true
    };

    Process.Start(processInfo);
  }
}
