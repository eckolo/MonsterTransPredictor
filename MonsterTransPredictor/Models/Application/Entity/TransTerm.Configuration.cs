using System.Data.Entity.ModelConfiguration;

namespace MonsterTransPredictor.Models.Application.Entity
{
    public partial class TransTerm
    {
        /// <summary>
        /// コードファーストでのDB反映時の特殊設定記述クラス
        /// </summary>
        public class Configuration : EntityTypeConfiguration<TransTerm>
        {
            public Configuration()
            {
                Property(entity => entity._hpLimit).HasColumnName("hpLimit");
                Ignore(entity => entity.hpLimit);
            }
        }
    }
}