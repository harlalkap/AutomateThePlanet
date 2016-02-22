﻿namespace PatternsInAutomation.Tests.Advanced.Specifications
{
	public class OrSpecification<TEntity> : Specification<TEntity>
	{
        private readonly ISpecification<TEntity> leftSpecification;
        private readonly ISpecification<TEntity> rightSpecification;

		public OrSpecification(ISpecification<TEntity> leftSpecification, ISpecification<TEntity> rightSpecification)
		{
			this.leftSpecification = leftSpecification;
			this.rightSpecification = rightSpecification;
		}

		public override bool IsSatisfiedBy(TEntity entity)
		{
			return this.leftSpecification.IsSatisfiedBy(entity) || this.rightSpecification.IsSatisfiedBy(entity);
		}
	}
}
