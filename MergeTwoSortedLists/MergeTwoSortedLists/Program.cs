// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/**
 
Definition for singly-linked list.
public class ListNode {
public int val;
public ListNode next;
public ListNode(int val=0, ListNode next=null) {
this.val = val;
this.next = next;
}
}
*/
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        Console.WriteLine("Hello, World!");

        if (list1 == null) return list2;
        if (list2 == null) return list1;

        if (list1.val <= list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        list2.next = MergeTwoLists(list1, list2.next);
        return list2;
    }

    public void main(String[] args)
    {
        Console.WriteLine("Hello, World!");
        ListNode list1 = new ListNode(4);
        ListNode list2 = new ListNode(3, list1);
        ListNode list3 = new ListNode(1, list2);

        ListNode list4 = new ListNode(4);
        ListNode list5 = new ListNode(2, list4);
        ListNode list6 = new ListNode(1, list5);
    }


 
}

