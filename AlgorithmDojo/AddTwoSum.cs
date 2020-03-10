using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDojo
{
    public class AddTwoSum
    {
        public List<ListNode> AddTwoNumber()
        {
            var listNode1 = setNode(2, 4, 3);
            listNode1.Reverse();
            var listNode2 = setNode(5, 6, 4);
            listNode2.Reverse();

            var vallistNode1 = listNode1.Select(it => it.val);
            var val1Str = string.Join("", vallistNode1).ToString();
            var val1 = Convert.ToInt32(val1Str);

            var vallistNode2 = listNode2.Select(it => it.val);
            var val2Str = string.Join("", vallistNode2).ToString();
            var val2 = Convert.ToInt32(val2Str);

            var result = val1 + val2;
            var resultListNode = result.ToString().Select(it => it.ToString()).Reverse().ToList();

            return setNode(Convert.ToInt32(resultListNode[0]), Convert.ToInt32(resultListNode[1]), Convert.ToInt32(resultListNode[2]));

        }

        public List<ListNode> setNode(int v1, int v2, int v3)
        {
            var node1 = new ListNode(v1);
            var node2 = new ListNode(v2);
            node1.next = node2;
            var node3 = new ListNode(v3);
            node2.next = node3;
            node3.next = null;

            var listNode = new List<ListNode>();
            listNode.AddRange(new List<ListNode> {
                node1,
                node2,
                node3
            });
            return listNode;
        }
        // ข้อจำกัดของ array เรายัดไปทั้ง Object ไม่ได้ถ้าเรามีฟีล เราต้องยัดฟีลด้วย
        public string[] AddTwoNumberBasic()
        {
            var arrayNode1 = setNodeBasic(2, 4, 3);
            var arrayNode1Temp = new int[3];
            // reverse
            for (int i = 0; i < arrayNode1.Length; i++)
            {
                arrayNode1Temp[i] = arrayNode1[arrayNode1.Length - (i + 1)].val;
            }
            var arrayVal1 = new string[3];
            for (int i = 0; i < arrayNode1Temp.Length; i++)
            {
                arrayVal1[i] = arrayNode1Temp[i].ToString();
            }
            var resultV1 = "";
            foreach (var val1 in arrayVal1)
            {
                resultV1 += val1;
            }
            var result1 = Convert.ToInt32(resultV1);

            var arrayNode2 = setNodeBasic(5, 6, 4);
            var arrayNode2Temp = new int[3];
            // reverse
            for (int i = 0; i < arrayNode2.Length; i++)
            {
                arrayNode2Temp[i] = arrayNode2[arrayNode2.Length - (i + 1)].val;
            }
            var arrayVal2 = new string[3];
            for (int i = 0; i < arrayNode2Temp.Length; i++)
            {
                arrayVal2[i] = arrayNode2Temp[i].ToString();
            }
            var resultV2 = "";
            foreach (var val1 in arrayVal2)
            {
                resultV2 += val1;
            }
            var result2 = Convert.ToInt32(resultV2);

            var result = result1 + result2;
            var finalResult = new string[3];
            for (int i = 0; i < result.ToString().Length; i++)
            {
                finalResult[i] = result.ToString()[result.ToString().Length - (i + 1)].ToString();
            }
            return finalResult;
        }

        public ListNode[] setNodeBasic(int v1, int v2, int v3)
        {
            var node1 = new ListNode(v1);
            var node2 = new ListNode(v2);
            node1.next = node2;
            var node3 = new ListNode(v3);
            node2.next = node3;
            node3.next = null;

            var listNode = new ListNode[3];
            listNode[0] = node1;
            listNode[1] = node2;
            listNode[2] = node3;
            return listNode;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

}