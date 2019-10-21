using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using DinoDiner.Menu;
using System.Collections.ObjectModel;
using System.Linq;


namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void ItemListAddsItems()
        {

            // I have no idea how to use moq lol

            int num = 3;
            var o = new Mock<Order>();
            o.Setup(x => Enumerable.Repeat(Mock.Of<IOrderItem>(), num).ToList());
            ObservableCollection<Mock<IOrderItem>> l = new ObservableCollection<Mock<IOrderItem>>();
            var itemOne = new Mock<IOrderItem>();
            itemOne.Setup(x => x.Price).Returns(5.67);
            var itemTwo = new Mock<IOrderItem>();
            itemTwo.Setup(x => x.Price).Returns(5.67);



            




        }
    }
}
