using Microsoft.EntityFrameworkCore;
using PostgresDBEntitySample.Entities;

namespace PostgresDBEntitySample
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// 接続情報文字列
        /// </summary>
        private string _connectionString = string.Empty;

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        /// <param name="connectionString">接続情報文字列</param>
        public AppDbContext ( string connectionString ) => _connectionString = connectionString;

        /// <summary>
        /// ToDo情報を管理するエンティティ
        /// </summary>
        public DbSet<ToDo> Todos { get; set; }

        /// <summary>
        /// データベースの接続設定を構成
        /// </summary>
        /// <remarks>
        /// データベースの接続設定を構成します。
        /// このメソッドは、Entity Framework Coreがデータベースに接続するために必要なオプションを指定します。
        /// PostgreSQLデータベースへの接続文字列を使用して、DbContextのオプションを設定します。
        /// </remarks>
        /// <param name="optionsBuilder">DbContextのオプションビルダー。</param>
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder )
            => optionsBuilder.UseNpgsql ( _connectionString );
    }
}
