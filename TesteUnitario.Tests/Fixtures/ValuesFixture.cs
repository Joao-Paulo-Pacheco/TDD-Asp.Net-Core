using System.Collections;
using System.Collections.Generic;

namespace TesteUnitario.Tests.Fixtures
{
    public class ValuesFixture : IEnumerable<object[]>
    {
        private readonly List<object[]> _data = new List<object[]>()
        {
            new object[]{ 1,2,3},
            new object[]{ 2,3,5},

        };

        public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
