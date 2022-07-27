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

            if (Length > 1)
            {
                var newElement = _topElement.Add(value, index);
                if (newElement.value < _minElement.value)
                {
                    _minElement = newElement;
                }
            }
        }

        public void RemoveMinElement()
        {
            if (_minElement.parent != null)
            {
                if (_minElement.right == null)
                {
                    //дочерних элементов нет; просто забываем этот элемент
                    _minElement = _minElement.parent;
                    _minElement.left = null;
                }
                else
                {
                    _minElement.parent.left = _minElement.right;
                    _minElement.right.parent = _minElement.parent;

                    _minElement = _minElement.right;
                    while (_minElement.left != null)
                    {
                        _minElement = _minElement.left;
                    }
                }
            }
            else //это верхний элемент
            {
                _topElement = _topElement.right;

                //убираем ссылку верхний элемент
                _topElement.parent = null;

                _minElement = _topElement;
                while (_minElement.left != null)
                {
                    _minElement = _minElement.left;
                }
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

        public BinaryTreeElement Add(int value, int index)
        {
            if (value < this.value)
            {
                if (this.left == null)
                {
                    this.left = new BinaryTreeElement(value, this, index);
                    return this.left;
                }
                else
                {
                    return this.left.Add(value, index);
                }
            }
            else
            {
                if (this.right == null)
                {
                    this.right = new BinaryTreeElement(value, this, index);
                    return this.right;
                }
                else
                {
                    return this.right.Add(value, index);
                }
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
