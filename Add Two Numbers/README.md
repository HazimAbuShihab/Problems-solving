# Add Two Numbers

You are given two **_non-empty_** linked lists representing two non-negative integers. The digits are stored in **_reverse order_**, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

## Method
```C#
public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{

}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
```

## Examples
![alt text](https://assets.leetcode.com/uploads/2020/10/02/addtwonumber1.jpg)
```bash
Input: l1 = [2,4,3], l2 = [5,6,4]
Output: [7,0,8]
```
```bash
Input: l1 = [0], l2 = [0]
Output: [0]
```
```bash
Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
Output: [8,9,9,9,0,0,0,1]
```