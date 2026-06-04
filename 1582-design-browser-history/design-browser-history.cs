public class BrowserHistory {
private string currenturl;
private Stack<string> historyStack = new Stack<string>();
private Stack<string> forwardStack = new Stack<string>();
    public BrowserHistory(string homepage) {
        currenturl=homepage;
    }
    
    public void Visit(string url) {
        if(this.currenturl==null){
            this.currenturl=url;
            return;
        }
        historyStack.Push(this.currenturl);
        this.currenturl=url;
        forwardStack.Clear();
    }
    
    public string Back(int steps) {
        while(steps>0 && historyStack.Count>0){
            forwardStack.Push(currenturl);
            this.currenturl=historyStack.Pop();
            steps--;

        }
        return currenturl;
    }
    
    public string Forward(int steps) {
        while(steps>0 && forwardStack.Count>0 ){
            historyStack.Push(currenturl);
            currenturl=forwardStack.Pop();
            steps--;
        }
        return currenturl;
    }
}

/**
 * Your BrowserHistory object will be instantiated and called as such:
 * BrowserHistory obj = new BrowserHistory(homepage);
 * obj.Visit(url);
 * string param_2 = obj.Back(steps);
 * string param_3 = obj.Forward(steps);
 */