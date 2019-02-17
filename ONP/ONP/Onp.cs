using System;
using System.Collections.Generic;
using System.Text;

namespace ONP
{
    public class Onp
    {
        private Stack<char> operatorsStack = new Stack<char>();

        public string ConvertToOnp(string input)
        {
            string result = "";

            foreach (char element in input)
            {

                if (element >= 'a' && element <= 'z')
                {
                    result = result + element;
                }
                else if (element == '(')
                {
                    operatorsStack.Push(element);
                }
                else if (element == ')')
                {
                    while (operatorsStack.Peek() != '(')
                    {
                        result = result + operatorsStack.Pop();
                    }
                    operatorsStack.Pop();

                }
                else
                {
                    int operatorPriority = AssignPriorityForOperator(element);

                    if(operatorsStack.Count == 0 || operatorPriority > AssignPriorityForOperator(operatorsStack.Peek()))
                    {
                        operatorsStack.Push(element);
                    }
                    else
                    {
                        while (operatorPriority <= AssignPriorityForOperator(operatorsStack.Peek()))
                        {
                            result = result + operatorsStack.Pop();
                        }
                        operatorsStack.Push(element);
                    }
                }
            }

            int elementsLeft = operatorsStack.Count;
            for (int i = 0; i < elementsLeft; i++)
            {
                result = result + operatorsStack.Pop();
            }

            return result;
        }

        private int AssignPriorityForOperator(char testedOperator)
        {
            int priority = -1;
            switch (testedOperator)
            {
                case '(':
                    priority = 0;
                    break;
                case '+':
                case '-':
                case ')':
                    priority = 1;
                    break;
                case '*':
                case '/':
                    priority = 2;
                    break;
                case '^':
                    priority = 3;
                    break;
            }

            return priority;
        }

    }
}
