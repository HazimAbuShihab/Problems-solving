namespace Add_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            var result = AddTwoNumbers(l1, l2);
        }
        // My Solution 
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null; // Head of the new linked list to be return 
            ListNode temp = null; // Temp for next node in LinkedList 

            // Carry
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                int sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next; // Change the head of l1 
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next; // Change the Head of l2 
                }
                ListNode node = new ListNode(sum % 10); // The expression "sum % 10" gives us the remainder when the sum is divided by 10, which is always the ones place digit of the sum. 
                carry = sum / 10;
                if (temp == null)
                {
                    temp = head = node;
                }
                // For any other node
                else
                {
                    temp.next = node;
                    temp = temp.next;
                }
            }
            if (carry > 0)
            {
                temp.next = new ListNode(carry);
            }
            return head;
        }

        // Best Performance solution
        //public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        //{
        //    if (l1 == null) return l2;
        //    if (l2 == null) return l1;

        //    ListNode inicio = l1;
        //    SomaNoLeft(l1, l2);

        //    return inicio;
        //}

        //private void SomaNoLeft(ListNode left, ListNode right)
        //{
        //    int resto = 0;
        //    ListNode penultimo = null;

        //    while (right is not null || resto != 0)
        //    {
        //        left.val = Soma(left.val, right?.val ?? 0, ref resto);
        //        if (left.next is null)
        //        {
        //            left.next = new();
        //        }
        //        penultimo = left;
        //        left = left.next;
        //        right = right?.next;
        //    }

        //    if (penultimo is not null &&
        //        left.val == 0 &&
        //        left.next is null)
        //    {
        //        penultimo.next = null;
        //    }
        //}

        //private int Soma(int a, int b, ref int resto)
        //{
        //    int sum = a + b + resto;
        //    resto = 0;

        //    if (sum / 10 > 0)
        //    {
        //        sum = sum - 10;
        //        resto = 1;
        //    }

        //    return sum;
        //}
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
