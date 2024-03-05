using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Readable
{
    public class ReadableCode
    {
        // BAD    : 良くない
        // NOTBAD : 別に悪くはない
        // GOOD   : いい書き方、推奨
        private void 右に長いコードを書かない()
        {
            var dtos = new List<ProductDto>();
            // BAD:右に長いコードを書かない(となりぐらいまでにする)
            ProductSqlServer.GetProducts().Where(x => x.Price > 100).ToList().ForEach(x => dtos.Add(new ProductDto(x)));

            // 改行しても右に長いコードには変わりない
            ProductSqlServer.GetProducts()
                .Where(x => x.Price > 100)
                .ToList().ForEach(x => dtos.Add(new ProductDto(x)));

            // ListのForEachをするためにToListするのは冗長
            var products1 = ProductSqlServer.GetProducts().Where(x => x.Price > 100).ToList();
            products1.ForEach(x => dtos.Add(new ProductDto(x)));

            // GOOD:隣のとなりまでしか訪ねない
            var products2 = ProductSqlServer.GetProducts().Where(x => x.Price > 100);
            foreach (var product in products2)
            {
                dtos.Add(new ProductDto(product));
            }

            // 右に長くなるという事とクラスをうまく分割できていない
        }

        // 判断(if文)
        // IFとELSEがある場合はIFはTrueの時に入る
        private void IFとELSEがある場合はIFはTrueの時に入る()
        {

        }
    }
}
