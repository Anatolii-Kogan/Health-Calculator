/*
 * author: Anatolii Kogan
 * e-mail: kogan.1anatoli@gmail.com
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Health_Calculator
{
    public class BinaryTreeController
    {
        public int Length { get; private set; } = 0;
        private BinaryTreeElement _topElement { get; set; } = null;
        private BinaryTreeElement _minElement { get; set; } = null;

        private readonly int _maxLength = 10;

        public BinaryTreeController(int maxLength)
        {
            _maxLength = maxLength;
        }

        public void Add(int value, int index)
        {
            if (_topElement == null)
            {
                _topElement = new BinaryTreeElement(value, null, index);
                _minElement = _topElement;
            }

            if (Length == _maxLength)
            {
                //если меньше или равно, то не имеет смысла учитывать его среди итак максимальных чисел
                if (value <= _minElement.value)
                {
                    return;
                }
                else
                {
                    RemoveMinElement();
                }
            }

            Length++;

            _topElement.Add(value, index);
        }

        public void RemoveMinElement()
        {
            if (_minElement.parent != null)
            {
                if (_minElement.right == null)
                {
                    _minElement = _minElement.parent;
                    _minElement.left = null;
                }
                else
                {
                    var newMin = _minElement.right;
                    _minElement.right = null;

                    var tempParent = _minElement.parent;
                    tempParent.left = newMin;

                    _minElement = newMin;
                    //все ссылки на прошлый минимальном элементе убраны
                }
            }
            else
            {
                _topElement = _topElement.right;
                _topElement.parent = null;
                //ссылки на предыдущий верхний элемент убраны
            }

            Length--;
        }

        private List<BinaryTreeElement> ToList()
        {
            List<BinaryTreeElement> elements = new List<BinaryTreeElement>(Length);
            elements.Add(_topElement);
            _topElement.AddChildrenToList(elements);

            return elements;
        }

        public int[] GetTreeElements()
        {
            int[] elements = new int[Length];
            var treeElements = ToList();

            for (int i = 0; i < Length; i++)
            {
                elements[i] = treeElements[i].value;
            }

            return elements;
        }

        public int[] GetTreeElementsIndexes()
        {
            int[] elements = new int[Length];
            var treeElements = ToList();

            for (int i = 0; i < Length; i++)
            {
                elements[i] = treeElements[i].index;
            }

            return elements;
        }
    }

    public class BinaryTreeElement
    {
        public BinaryTreeElement parent, left, right;
        public int value;
        public int index;

        public BinaryTreeElement(int value, BinaryTreeElement parent, int index)
        {
            this.value = value;
            this.parent = parent;
            this.index = index;
        }

        public void Add(int value, int index)
        {
            if (value.CompareTo(this.value) < 0)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTreeElement(value, this, index);
                }
                else if (this.left != null)
                    this.left.Add(value, index);
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTreeElement(value, this, index);
                }
                else if (this.right != null)
                    this.right.Add(value, index);
            }
        }

        public void AddChildrenToList(List<BinaryTreeElement> elements)
        {
            if (right != null)
            {
                elements.Add(right);
                right.AddChildrenToList(elements);
            }

            if (left != null)
            {
                elements.Add(left);
                left.AddChildrenToList(elements);
            }
        }
    }
}
