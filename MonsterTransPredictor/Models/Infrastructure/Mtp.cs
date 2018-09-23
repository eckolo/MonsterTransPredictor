namespace MonsterTransPredictor.Models.Infrastructure
{
    using MonsterTransPredictor.Models.Application.Entity;
    using System.Data.Entity;

    public class Mtp : DbContext
    {
        // コンテキストは、アプリケーションの構成ファイル (App.config または Web.config) から 'Mtp' 
        // 接続文字列を使用するように構成されています。既定では、この接続文字列は LocalDb インスタンス上
        // の 'MonsterTransPredictor.Models.Infrastructure.Mtp' データベースを対象としています。 
        // 
        // 別のデータベースとデータベース プロバイダーまたはそのいずれかを対象とする場合は、
        // アプリケーション構成ファイルで 'Mtp' 接続文字列を変更してください。
        public Mtp()
            : base("name=Mtp")
        {
        }

        // モデルに含めるエンティティ型ごとに DbSet を追加します。Code First モデルの構成および使用の
        // 詳細については、http://go.microsoft.com/fwlink/?LinkId=390109 を参照してください。

        public virtual DbSet<Monster> monsters { get; set; }

        public virtual DbSet<Skill> skills { get; set; }

        public virtual DbSet<Monster.TransTerm> transTerms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Monster.TransTerm.Configuration());
        }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}