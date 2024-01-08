public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        //initialize three pointers...
        var p1 = m - 1;//one for the last item in nums1
        var p2 = n - 1;//one for the last item in nums2
        var p = m + n - 1;//and one for the last space in the merged array
        //until either pointer reaches start of array
        while(p1 >= 0 && p2 >= 0) {
            if(nums1[p1] > nums2[p2]) {
                nums1[p] = nums1[p1];
                p1--;//move left
            } else {
                nums1[p] = nums2[p2];
                p2--;//move left
            }
            p--;//move left
        }
        //if p2 is stil not at the beginning, copy remaining items from nums2 to nums1
        while(p2 >= 0) { //loop until p2 reaches the beginning
            nums1[p] = nums2[p2];//assign nums1[p] to nums2[p2]
            p2--;//move p2 to the left
            p--;//move p to the left
        }
    }
}
