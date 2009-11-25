using System;
using System.Windows.Input;

namespace Part4.MixItUp
{
	public class DelegateCommand : ICommand
	{
		private readonly Action execute;
		private readonly Func<bool> canExecute;

		public DelegateCommand(Action execute)
			: this(execute, () => true)
		{
			this.execute = execute;
		}

		public DelegateCommand(Action execute, Func<bool> canExecute)
		{
			this.execute = execute;
			this.canExecute = canExecute;
		}

		public void Execute(object parameter)
		{
			if (canExecute())
				execute();
		}

		public bool CanExecute(object parameter)
		{
			return canExecute();
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}
}