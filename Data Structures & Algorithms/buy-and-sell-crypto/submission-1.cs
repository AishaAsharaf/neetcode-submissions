public class Solution {
    public int MaxProfit(int[] prices) {
        int result = 0;
        int buy = 0;
        int sell = 1;
        while(sell < prices.Length){
             if(prices[buy]<prices[sell])
             {
                int profit = prices[sell]-prices[buy];
                result = Math.Max(result,profit);
             }
             else{
                buy = sell;
             }
             sell++;
        }
        return result;
    }
}
