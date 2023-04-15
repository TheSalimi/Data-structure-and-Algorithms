#include <set>
#include <iostream>
#include <vector>

using namespace std;

const int maxn = 2000;
bool marked[maxn];
int pops[maxn];
vector <int> adj[maxn];


int main()
{
    ios_base::sync_with_stdio(false); cin.tie(0);
    int n;
    int m;
    cin >> n >> m;
    for (int i = 0; i < n; i++)
        cin >> pops[i];
    int i = 0;
    while (i<m)
    {
        int u;
        int v;
        cin >> u >> v;
        u -= 1;
        v-= 1;
        adj[u].push_back(v);
        adj[v].push_back(u);
        i++;
    }
    int v = 0;
    while(v<n)
    {
        set <pair <int, int> > cnt_pops;
        long long int pop = pops[v], extraPop = 0;
        for (int i = 0; i < n; i++)
            marked[i] = false;
        marked[v] = true;
        for (int u : adj[v])
            if (!marked[u])
                cnt_pops.insert(make_pair(pops[u], u));
        for (int i = 0; i < n - 1; i++)
        {
            int u = (*cnt_pops.begin()).second;
            marked[u] = true;
            cnt_pops.erase(cnt_pops.begin());
            for (int w : adj[u])
                if (!marked[w])
                    cnt_pops.insert(make_pair(pops[w], w));
            if(pops[u]>= pop+extraPop)
            {
                extraPop += pops[u] - (pop + extraPop) + 1;
                pop += pops[u];
            }
            else 
                pop += pops[u];
        }

        if (v == n - 1)
            cout << extraPop;
        else
            cout << extraPop << " ";
        v++;
    }

    return 1;
}