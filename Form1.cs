using System.Diagnostics;
namespace cs_form_delegate_anonymous_struct;

public partial class Form1 : Form
{
    // 定義済み delegate + ラムダ式で匿名メソッドの定義
    private Func<string> myDbg = () => { return "DBG"; };
    private Action<string> print = (message) => { Debug.WriteLine($"DBG:{message}"); };

    // 構造体
    private struct DbConnect {
            public string host;
            public string user;
            public string password;
            public string database;
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void action_Click(object sender, EventArgs e)
    {

        Debug.WriteLine($"{myDbg()}:こんにちは");
        print("こんにちは世界");

        // 匿名型の変数( ローカルのみ / ReadOnly )
        var connect = new { host = "localhost", user = "root", password = "", database = "lightbox" };
        print(connect.ToString());
        print($"{connect.host} : {connect.user}");

        // 構造体
        DbConnect dbConnect = new DbConnect { host = "localhost", user = "root", password = "", database = "lightbox" };
        print(dbConnect.ToString());
        print($"{dbConnect.host} : {dbConnect.user}");

        DbConnect dbConnect2;
        dbConnect2.host = "localhost2";
        dbConnect2.user = "root2";
        dbConnect2.password = "";
        dbConnect2.database = "lightbox2";
        print($"{dbConnect2.host} : {dbConnect2.user}");
        print(dbConnect2.ToString());

    }

}
