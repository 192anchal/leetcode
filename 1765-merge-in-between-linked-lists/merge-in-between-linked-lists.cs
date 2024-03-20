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
public class Solution {
    public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2) {
       var ptr1 = list1;
        var ptr2 = list1;
        while(a > 1)
        {
            a--;
            ptr1 = ptr1.next;
        }
        while(b > 0)
        {
            b--;
            ptr2 = ptr2.next;
        }
        ptr1.next = list2;
        var ptr3 = list2;
        while(ptr3.next != null)
        {
            ptr3 = ptr3.next;
        }
        ptr3.next = ptr2.next;
        ptr2.next = null;
        return list1;
 
        
    }
}