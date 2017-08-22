namespace InfernoInfinity.Client.Core
{
    using Contracts;
    using Contracts.Core;

    public class Engine : IEngine
    {
        private readonly CommandInterpreter _commandInterpreter;
        private readonly IReader _reader;

        public Engine(CommandInterpreter commandInterpreter, IReader reader)
        {
            this._commandInterpreter = commandInterpreter;
            this._reader = reader;
        }

        public void Run()
        {
            string input = this._reader.ReadLine();

            while (this._commandInterpreter.IsRunning)
            {
                this._commandInterpreter.InterpredCommand(input);

                if (this._commandInterpreter.IsRunning)
                {
                    input = this._reader.ReadLine();
                }
            }
        }
    }
}