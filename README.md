# cs-delegate-struct

## namespace form_03

### 定義済み delegate + ラムダ式で匿名メソッドの定義
```cs
    private Func<string> myDbg = () => { return "DBG"; };
    private Action<string> print = (message) => { Debug.WriteLine($"DBG:{message}"); };

```
### [Func<TResult> Delegate](https://learn.microsoft.com/ja-jp/dotnet/api/system.func-1?view=net-6.0)\
### [Action Delegate](https://learn.microsoft.com/ja-jp/dotnet/api/system.action?view=net-6.0)

### 構造体
```cs
    private struct DbConnect {
            public string host;
            public string user;
            public string password;
            public string database;
    }
```

### 匿名型の変数( ローカルのみ / ReadOnly )
```cs
        var connect = new { host = "localhost", user = "root", password = "", database = "lightbox" };
        print(connect.ToString());
        print($"{connect.host} : {connect.user}");
```

### 構造体
```cs
        DbConnect dbConnect = new DbConnect { host = "localhost", user = "root", password = "", database = "lightbox" };
        print(dbConnect.ToString());
        print($"{connect.host} : {connect.user}");

        DbConnect dbConnect2;
        dbConnect2.host = "localhost";
        dbConnect2.user = "root";
        print($"{connect.host} : {connect.user}");
```
