namespace Game
{
    public class GameTime
    {
#if CLIENT
        Cell<long> _currTimeCell = new Cell<long>();
        public ICell<long> currTimeCell => _currTimeCell;
        long _currTime { get => _currTimeCell.value; set => _currTimeCell.value = value; }
#else
        long _currTime;
#endif
        public GameTime()
        {
            _currTime = -1;
        }
        public bool set => _currTime != -1;
        
        // Ticks after 1970.
        public long currTime { get => _currTime; set => _currTime = value; }
        public static implicit operator long(GameTime time) => time.currTime;
    }
}