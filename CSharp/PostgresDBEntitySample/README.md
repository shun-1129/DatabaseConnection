# PostgresDBEntitySample

## このプログラムについて

本プログラムは.NET 6 を用いて作成されたライブラリになります。  
Entity Framework PostgreSQL を使用しています。

本プログラムをビルドした際に出力される DLL を使用する際には、Entity Framework PostgreSQL をインストールしておく必要があります。

Visual Studio を使用している場合、Package Manager Console を開き（Tools > NuGet Package Manager > Package Manager Console）、次のコマンドを実行

```
Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -Version 7.0.18
```

-Version は 2024/09/22 現在最新の 8.0.4 は.NET6 へ未サポートのため過去バージョンになっています。

使用される.NET のバージョンに合わせて変更してください。

## データベース マイグレーション実行方法

1. 下記コードをコメントアウト

```
public AppDbContext ( string connectionString ) => _connectionString = connectionString;
```

2. 下記コードを以下に変更

```
protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
    => optionsBuilder.UseNpgsql ( "Host=localhost;Database=<任意のDB名>;Username=postgres;Password=<設定したパスワード>;" );
```

3. Visual Studio を使用している場合、Package Manager Console を開き（Tools > NuGet Package Manager > Package Manager Console）、次のコマンドを実行

```
Add-Migration InitialCreate
Update-Database
```

pgAdmin4 等で確認すると、指定した DB 名のデータベースが作成されると共にテーブルが生成されています。
